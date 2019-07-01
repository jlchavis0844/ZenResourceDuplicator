using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using unirest_net.http;
using System.Linq;
using System.Diagnostics;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace ZenResourceDuplicator {
    public partial class Form1 : Form {
        public static string token;
        public static FileStream fileStream;
        public static Dictionary<int, string> owners;
        public static JObject data;

        /// <summary>
        /// Form contructor. Runs serveral setup calls.
        /// </summary>
        public Form1() {
            InitializeComponent();//build form
            comboBox1.SelectedIndex = 0; //pick first object type list
            token = LoadToken(); // reads in API key
            owners = LoadOwners(); // fetches a list of owners
            Object[] ownerArray = new Object[owners.Count];
            int[] keys = owners.Keys.ToArray();

            for(int i = 0; i < owners.Count; i++) {
                ownerArray[i] = owners[keys[i]];
            }
            Array.Sort(ownerArray);
            cbOwners.Items.AddRange(ownerArray);
            if(token == "#ERROR") {
                MessageBox.Show("Could Not Load Token", "NO TOKEN", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        /// <summary>
        /// loads plain text api key from a file called token
        /// </summary>
        /// <returns>API Key</returns>
        private string LoadToken() {
            string tStr = "";
            //default location
            fileStream = new FileStream(@"C:\apps\NiceOffice\token", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (var sr = new StreamReader(fileStream)) {
                tStr = sr.ReadToEnd();
            }

            fileStream.Close();

            if (tStr != null && tStr != "") {
                return tStr;
            } else return "#ERROR";//error checking in calling function.
        }


        /// <summary>
        /// makes a get call using Unirest. Returns response as string.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <returns>string of the JSON data</returns>
        public static string Get(string url, string token) {
            string body = "";
            try {
                HttpResponse<string> jsonReponse = Unirest.get(url)
                    .header("accept", "application/json")
                    .header("Authorization", "Bearer " + token)
                    .asJson<string>();
                body = jsonReponse.Body.ToString();
                return body;
            } catch (Exception ex) {
                Console.WriteLine(ex);
                return body;
            }
        }

        /// <summary>
        /// makes post call and returns JObject using Unirest
        /// </summary>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static JObject Post(string url, string token, JObject body) {
            JObject jBody = new JObject();
            jBody["data"] = data;
            string bodyStr = jBody.ToString();
            try {
                HttpResponse<string> jsonReponse = Unirest.post(url)
                    .header("accept", "application/json")
                    .header("Authorization", "Bearer " + token)
                    .header("Content-Type", "application/json")
                    .header("Host", "api.getbase.com")
                    .header("accept-encoding", "application/json")
                    .header("content-length", "832")
                    .header("Connection", "keep-alive")
                    .header("cache-control", "no-cache")
                    .body(bodyStr)
                    .asString();
                return JObject.Parse(jsonReponse.Body);
            } catch (Exception ex) {
                Console.WriteLine(ex);
                return null;
            }
        }

        /// <summary>
        /// Returns the load or contact from Base
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private JObject GetResource(string type, int id) {
            string tJSON = Get(@"https://api.getbase.com/v2/" + type + @"/" + id, token);
            JObject jObj = JObject.Parse(tJSON) as JObject;
            return jObj["data"] as JObject;
        }

        /// <summary>
        /// fetches a list of the active users in base that can be assinged a resource
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> LoadOwners() {
            Dictionary<int, string> tDict = new Dictionary<int, string>();

            string testJSON = Get(@"https://api.getbase.com/v2/users?per_page=100&sort_by=created_at&status=active", token);
            JObject jObj = JObject.Parse(testJSON) as JObject;
            JArray jArr = jObj["items"] as JArray;

            foreach (var obj in jArr) {
                var data = obj["data"];
                int tID = Convert.ToInt32(data["id"]);
                string tName = data["name"].ToString();
                tDict[tID] = tName;
            }

            return tDict;
        }

        /// <summary>
        /// Listener to turn off new tag text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbNo_CheckedChanged(object sender, EventArgs e) {
            txtNewTag.Visible = !rbNo.Checked;
        }

        /// <summary>
        /// Listener to turn off new tag text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbYes_CheckedChanged(object sender, EventArgs e) {
            txtNewTag.Visible = rbYes.Checked;
        }

        /// <summary>
        /// On enter being pressed in the resource id text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRID_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                int ID = -1;
                //if not numberic
                if(!Int32.TryParse(txtRID.Text,out ID)){
                    MessageBox.Show("Resource ID must be numeric", "ERROR - ID Number", MessageBoxButtons.OK);
                    btnGo.Enabled = false;
                    return;
                }
                
                string rType = (comboBox1.SelectedIndex == 0) ? "leads" : "contacts";
                data = GetResource(rType, Convert.ToInt32(txtRID.Text));

                //error check on getting resource
                if (data == null) {
                    MessageBox.Show("Error fetching the resource!\nTry checking type and ID number", "ERROR - Fetching", MessageBoxButtons.OK);
                    btnGo.Enabled = false;
                    return;
                }
                
                lblCurrentTags.Text = data["tags"].ToString();
                lblCurrentTags.Visible = true;
                lblRName.Text = data["first_name"].ToString() + " " + data["last_name"].ToString();
                btnGo.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e) {
            if(cbOwners.SelectedIndex == -1) {
                MessageBox.Show("Please Choose a new owner first", "PICK NEW OWNER", MessageBoxButtons.OK);
                return;
            }
            JArray tagArray = null;

            if(rbYes.Checked == true && txtNewTag.Text != null && txtNewTag.Text != "") {
                var newTags = data["tags"].ToList();
                bool dupe = false;
                foreach(string tag in newTags) {
                    if(tag == txtNewTag.Text) {
                        dupe = true ;
                        MessageBox.Show("Duplicate Tag found", "Dupe TAG", MessageBoxButtons.OK);
                    }
                }

                if (dupe == false) {
                    newTags.Add(txtNewTag.Text);
                    tagArray = new JArray(newTags);
                    data["tags"] = tagArray;
                }
            }
            if (data.Property("id") != null)
                data.Property("id").Remove();

            if (data.Property("unqualified_reason_id") != null)
                data.Property("unqualified_reason_id").Remove();
            if (data.Property("created_at") != null)
                data.Property("created_at").Remove();
            if (data.Property("updated_at") != null)
                data.Property("updated_at").Remove();
            if (data.Property("creator_id") != null)
                data.Property("creator_id").Remove();

            string selectedOwner = cbOwners.Items[cbOwners.SelectedIndex].ToString();
            var newOwnerID = owners.Where(owner => owner.Value == selectedOwner).First().Key;
            data["owner_id"] = newOwnerID;
            string rType = (comboBox1.SelectedIndex == 0) ? "leads" : "contacts";
            var result = Post(@"https://api.getbase.com/v2/" + rType, token, data);
            int newID = Convert.ToInt32(result["data"]["id"]);
            string link;
            
            if(rType == "leads") {
                link = @"https://app.futuresimple.com/leads/" + newID;
            } else {
                link = @"https://app.futuresimple.com/crm/contacts/" + newID;
            }

            lblLink.Text = link;
            lblLink.Visible = true;
            lblLink.Enabled = true;

            if(rbYes.Checked == true) {
                if(tagArray.ToString() != result["data"]["tags"].ToString()) {
                    string msg = "Could not Match tags.\nCurrent: \n" + result["data"]["tags"].ToString() +
                        "\nWanted: \n" + tagArray.ToString() + "\nTags are case sensitive. Check entered tag";
                    MessageBox.Show(msg, "TAG MISSMATCH", MessageBoxButtons.OK);
                }
                lblCurrentTags.Text = "Result Tag" + result["data"]["tags"].ToString();
            }
        }

        /// <summary>
        /// launch website on the created resource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = lblLink.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "https://" + url;

            var si = new ProcessStartInfo(url);
            Process.Start(si);
            lblLink.LinkVisited = true;
        }
    }
}
