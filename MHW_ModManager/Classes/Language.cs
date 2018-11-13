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
                    System.Diagnostics.Debug.WriteLine(file);
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
                    //遍历集合如果语言资源键值不存在，则创建，否则更新
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
            //如果没有资源，那么不必遍历控件，提高速度
            if (resources == null)
                return;

            //使用递归的方式对控件及其子控件进行处理
            SetControlLanguage(control);
            foreach (Control ctrl in control.Controls)
            {
                InitLanguage(ctrl);
            }

            //工具栏或者菜单动态构建窗体或者控件的时候，重新对子控件进行处理
            control.ControlAdded += (sender, e) =>
            {
                InitLanguage(e.Control);
            };
        }

        private void SetControlLanguage(Control control)
        {
            foreach (string value in resources.Values)
            {
                System.Diagnostics.Debug.WriteLine(value);
            }
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
