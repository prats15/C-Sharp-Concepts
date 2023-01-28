using System;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            string TypeName = textBoxType.Text;
            string name = typeof(Form).AssemblyQualifiedName;

            Type T = Type.GetType(name);

            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                listBoxMethod.Items.Add(method);
            }

            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo prop in properties)
            {
                listBoxProp.Items.Add(prop);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach(ConstructorInfo con in constructors)
            {
                listBoxConstructor.Items.Add(con);
            }
        }
    }
}
