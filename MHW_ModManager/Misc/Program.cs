using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace MHWModManager {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            /*try {

                AppDomain.CurrentDomain.AssemblyResolve += (s, e) => {
                    //This handler is called only when the common language runtime tries to bind to the assembly and fails.

                    //Retrieve the list of referenced assemblies in an array of AssemblyName.
                    Assembly MyAssembly, objExecutingAssemblies;
                    string strTempAssmbPath = "";

                    objExecutingAssemblies = Assembly.GetExecutingAssembly();
                    AssemblyName[] arrReferencedAssmbNames = objExecutingAssemblies.GetReferencedAssemblies();

                    //Loop through the array of referenced assembly names.
                    foreach (AssemblyName strAssmbName in arrReferencedAssmbNames) {
                        //Check for the assembly names that have raised the "AssemblyResolve" event.
                        if (strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) == e.Name.Substring(0, e.Name.IndexOf(","))) {
                            //Build the path of the assembly from where it has to be loaded.
                            strTempAssmbPath = Serializer.GetMMDataFolder() + e.Name.Substring(0, e.Name.IndexOf(",")) + ".dll";
                            if (!System.IO.File.Exists(strTempAssmbPath)) {
                                var errorBox = InputBoxForm.OKBOX("ERROR!", "");
                                errorBox.richTextBox1.WordWrap = true;
                                errorBox.richTextBox1.AppendText("Couldn't find .Dll's.", Color.Crimson, true);
                                errorBox.richTextBox1.AppendText("Make sure you haven't removed the ModManagerData folder or moved the .dll files in that folder.", Color.Coral, true);
                                errorBox.richTextBox1.SelectAll();
                                errorBox.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

                                errorBox.ShowDialog();
                                throw new FileNotFoundException();
                            }
                            break;
                        }

                    }
                    //Load the assembly from the specified path. 
                    byte[] assmbData = File.ReadAllBytes(strTempAssmbPath);
                    MyAssembly = Assembly.Load(assmbData);

                    //Return the loaded assembly.
                    return MyAssembly;
                };
            } catch {
                
            }*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
