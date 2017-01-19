using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Student
        {
            private string mName;
            private int mAge;
            private string mID;
            public Student() { }
            public Student(string mName, int mAge, string mID)
            {

            }
            public string Name
            {
                get
                {
                    return mName;
                }
                set
                {
                    mName = value;
                }
            }
            public int Age
            {
                get
                {
                    return mAge;
                }
                set
                {
                    mAge = value;
                }
            }
            public string ID
            {
                get
                {
                    return mID;
                }
                set
                {
                    mID = value;
                }
            }
        }

        class Serialization<T>
        {
            /// <summary>
            /// We invoke this function when have the data we want to serialize ready. The arguments we pass in to
            /// the functiom call tell the application where to save the data which by default is the project 
            /// directory two files deep in a folder called SavedFiles and inside that folder we will find a file
            /// with the name that matches the data stored inside the string passed into the function call
            /// Once that file has been found we then take the data passed into to function and write it to a said file
            /// </summary>
            /// <param name="fileName"></param>
            /// <param name="data"></param>
            public static void Serialize(string fileName, T data)
            {
                //creates a new XMLS Seualizer object with an argument of 
                //the type of the data passed in
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                //Creates a new TextWritter object and assigns it a StreamWritter 
                //object that takes in argument of the file path
                TextWriter writter = new StreamWriter(@"..\..\SavedFiles" + fileName + ".xml");
                //Invoke the Serialize function from the XmlSerialize class and pass in 
                //the TextWritter object created and the data we are trying to write to the file
                serializer.Serialize(writter, data);
                //Closes the file we were using to write our data
                writter.Close();
            }
            /// <summary>
            /// We invoke this function when we are trying load some data back into our application that has all ready been saved.
            /// This function will break if you are trying to find a file that does not exist. We specify the file we are looking
            /// for by the data stored in the string passed into the function call.
            /// </summary>
            /// <param name="fileName"></param>
            /// <returns></returns>
            public static T Deserialize(string fileName)
            {
                //Creates a new Generic object we will use to hold the data we are trying to return 
                T data;
                //creates a new XmlSerializer object with an argument of the type of generic object we are trying to create 
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                //creates a new textreader pbject with a child object of the class eith the argument of a string that is the 
                //file directory of the file we are trying to get the data from 
                TextReader reader = new StreamReader(@"..\..\SavedFiles\" + fileName + ".xml");
                //invokes the deserialize function from the XmlSerializer class and casts the return as the generis type and 
                //passes in the TextReader object as an argument into the function call
                data = (T)serializer.Deserialize(reader);
                //Closes the reader file 
                reader.Close();
                //Returns our generic object
                return data;
            }
            
        }
        /// <summary>
        /// Function that is invoked when the SaveData button is click by the user.
        /// This function will create a new student with the information provided by the user from the various
        /// fields on the winform
        /// Once we have the student created we will invoke the Serialize function from the DataSerialization class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveData_Click(object sender, EventArgs e)
        {
            //Creates a student and invoke the constructor with the arguments being the data from the various fields
            //in the winform
            Student curStudent = new Student(this.name.Text, (int)this.Age.Value, this.ID.Text);
            //Invokes the Serialize function from the DataSerialization class and gives it the arguments of the string 
            //"Student" and the newly created student
            Serialization<Student>.Serialize("Student", curStudent);
        }
        /// <summary>
        /// Function that is invoked when he LoadLast button is clicked by the user.
        /// This function will invoke the Deseriaize function to create a new student and take that data and assign 
        /// the data from that stsudent to the various fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadLast_Click(object sender, EventArgs e)
        {
            //Creates a new student with the information returned from the Deserialize function
            Student lastStudent = Serialization<Student>.Deserialize("Student");
            this.name.Text = lastStudent.Name;
            this.Age.Value = lastStudent.Age;
            this.ID.Text = lastStudent.ID;
        }
    }
}
