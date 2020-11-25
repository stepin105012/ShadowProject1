using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace griddata
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class DataGridWindow : Window
	{
		ListOfStudents Data;
		public DataGridWindow()
		{
			InitializeComponent();
			SerializeCollection("StudentData.xml");
			Data = Deserialzation();
			//std.Add(new DataGridContent() { Name = Data.Name, Birthday = Data.Birthday, Gender = Data.Gender });
			Student.ItemsSource = Data.Pupils;

		}
        private void button_Click(object sender, RoutedEventArgs e)
        {
			listbox.Items.Clear();
			foreach (DataGridContent dgc in Data.Pupils)
            {
				if(dgc.IsSelected == true)
                {
					string message = $"Hi This is { dgc.Name} wish me on {dgc.Birthday}";
					listbox.Items.Add(message);
                }
            }

		}
		private void SerializeCollection(string filename)
		{
            try
            {
				var listOfStudents = new ListOfStudents();
				var pupils = new List<DataGridContent>();
				pupils.Add(new DataGridContent() { Name = "Harini ", Birthday = "09-11-1998", Gender = "Female" , IsSelected=false});
				pupils.Add(new DataGridContent() { Name = "Chandana", Birthday = "14-09-1998", Gender = "Female", IsSelected=false });
				pupils.Add(new DataGridContent() { Name = "Anjali", Birthday = "20-02-1999", Gender = "Female", IsSelected=false});
				pupils.Add(new DataGridContent() { Name = "Binitta", Birthday = "24-11-1998", Gender = "Female",IsSelected=false });
				listOfStudents.Pupils = pupils;
				List<string>list = new List<string>();
				list.Add("Male");
				list.Add("Female");

				gender.ItemsSource = list;
				XmlSerializer x = new XmlSerializer(typeof(ListOfStudents));
				TextWriter writer = new StreamWriter(filename);
				x.Serialize(writer, listOfStudents);
				writer.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
		}
		public static ListOfStudents Deserialzation()
        { 
			ListOfStudents s;
			try
			{
				XmlSerializer sl = new XmlSerializer(typeof(ListOfStudents));
				FileStream fs = new FileStream("StudentData.xml", FileMode.Open, FileAccess.Read);
				s = (ListOfStudents)sl.Deserialize(fs);
				//Student.ItemsSource = s;
				fs.Flush();
				fs.Close();
				return s;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
            return null;
		}

        private void allData_Click(object sender, RoutedEventArgs e)
        {
			listbox.Items.Clear();
			foreach (DataGridContent dgc in Data.Pupils)
			{
					string message = $"Hi This is { dgc.Name} wish me on {dgc.Birthday}";
					listbox.Items.Add(message);
			}
		}
    }
    public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Birthday { get; set; }
		public string Gender { get; set; }

	}
	public class DataGridContent
    {
		public string Name { get; set; }
		public string Birthday { get; set; }
		public string Gender { get; set; }	
		public bool IsSelected { get; set; }
    }
	public class ListOfStudents
	{
	    public List<DataGridContent> Pupils { get; set; }
	}
}