using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    public class Language
    {
        private Dictionary<string, string> resources;

        private void LoadLanguage(string language = "")
        {
            if (string.IsNullOrEmpty(language))
            {
                language = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
            }

            this.resources = new Dictionary<string, string>();
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("ModManagerData\\lang\\{0}", language));
            if (Directory.Exists(dir))
            {
                var jsonFiles = Directory.GetFiles(dir, "*.json", SearchOption.AllDirectories);
                foreach (string file in jsonFiles)
                {
                    LoadFile(file);
                }
            }
        }

        private void LoadFile(string file)
        {
            var content = File.ReadAllText(file, Encoding.Default);
            if (!string.IsNullOrEmpty(content))
            {
                var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
                foreach (string key in dict.Keys)
                {
                    if (!resources.ContainsKey(key))
                    {
                        resources.Add(key, dict[key]);
                    }
                    else
                    {
                        resources[key] = dict[key];
                    }
                }
            }
        }

        public void InitLanguage(Control control)
        {
            LoadLanguage();
            if (resources == null)
                return;

            SetControlLanguage(control);
            foreach (Control ctrl in control.Controls)
            {
                InitLanguage(ctrl);
            }
            
            control.ControlAdded += (sender, e) =>
            {
                InitLanguage(e.Control);
            };
        }

        private void SetControlLanguage(Control control)
        {
            if (resources.ContainsKey(control.Name + ".Text"))
            {
                control.Text = resources[control.Name + ".Text"];
            }
        }

        public string GetLanguageText(string Translate)
        {
            LoadLanguage();
            if (resources == null)
                return Translate;
            if (resources.ContainsKey(Translate))
                return resources[Translate]; 
            else
                return Translate;
        }
    }
