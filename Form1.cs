using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Character_Sheet_Generator
{

	public partial class Character_Generator : Form
	{

		Fighter fighter;
		Wizard wizard;

		string[] heirarchyArray = { "Noble", "Commoner", "Peasant" };
		List<string> JobList = new List<string>();


		public Character_Generator()
		{
			InitializeComponent();
		}

		private void FighterGenerator_Click_1(object sender, EventArgs e)
		{
			
			string SocietalRole = HeirarchyList.SelectedItem.ToString();
			string JobRole = JobListBox.SelectedItem.ToString();
			string Character = "You are a " + string.Concat(SocietalRole, " who works as a ", JobRole);
			fighter = new Fighter(nameBox.Text);

			int cha = 6;
			int wis = 5;
			int str = 10;
			int intel = 7;
			int dex = 8;


			try
			{
				if (HeirarchyList.SelectedItem == null)
				{
					MessageBox.Show("Error, please select one option from each category.");
				}

				if (JobListBox.SelectedItem == null)
				{
					MessageBox.Show("Error, please select one option from each category.");
				}
				if (SocietalRole == "Noble")
				{
					cha = cha + 1;
					wis = wis + 1;
					str = str - 2;
					intel = intel + 3;
					dex = dex + 0;
				}

				else if (SocietalRole == "Commoner")
				{
					cha = cha + 3;
					wis = wis + 1;
					str = str + 1;
					intel = intel + 1;
					dex = dex + 1;
				}

				else if (SocietalRole == "Peasant")
				{
					cha = cha - 1;
					wis = wis + 4;
					str = str + 2;
					intel = intel + 0;
					dex = dex + 2;
				}

				if (JobRole == "Royal Advisor")
				{
					cha = cha + 2;
					wis = wis + 3;
					str = str - 1;
					intel = intel + 2;
					dex = dex - 2;
				}

				else if (JobRole == "Blacksmith")
				{
					cha = cha + 1;
					wis = wis + 1;
					str = str + 3;
					intel = intel + 0;
					dex = dex + 4;
				}

				else if (JobRole == "Soldier")
				{
					cha = cha - 2;
					wis = wis - 1;
					str = str + 2;
					intel = intel + 1;
					dex = dex + 1;
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

			//input the total gold and strength
			chaBox.Text = cha.ToString();
			wisBox.Text = wis.ToString();
			strBox.Text = str.ToString();
			intBox.Text = intel.ToString();
			dexBox.Text = dex.ToString();


			//Give your character random lucks
			Random rand = new Random();
			int luck = rand.Next(1, 5);

			luckBox.Text = luck.ToString();

			using (var writer = new StreamWriter(@"CharacterSheet.txt"))

			{
				MessageBox.Show("Sheet Created. Please Access CharacterSheet.txt in the bin>debug.");
				writer.WriteLine("Your Character, " + fighter.Name + " has been created. Here are your Stats.");
				writer.WriteLine("Charisma: " + cha.ToString());
				writer.WriteLine("Wisdom: " + wis.ToString());
				writer.WriteLine("Strength: " + str.ToString());
				writer.WriteLine("Intellegence:  " + intel.ToString());
				writer.WriteLine("Dexterity " + dex.ToString());
				writer.WriteLine("Luck is " + luck.ToString());
				writer.WriteLine(Character + " known as " + fighter.Name);
				writer.Close();
			}
		}

		private void Character_Generator_Load(object sender, EventArgs e)
		{
			foreach (string G in heirarchyArray)
			{
				HeirarchyList.Items.Add(G);
			}

			JobList.Add("Royal Advisor");
			JobList.Add("Blacksmith");
			JobList.Add("Soldier");

			foreach (string F in JobList)
			{
				JobListBox.Items.Add(F);
			}

			JobListBox.SelectedItem = "Royal Advisor";
			HeirarchyList.SelectedItem = "Noble";

			string s1 = "The quick brown fox jumps over the lazy dog";
			string s2 = "fox";
			bool b = s1.Contains(s2);
			Console.WriteLine("'{0}' is in the string '{1}': {2}",
							s2, s1, b);
			if (b)
			{
				int index = s1.IndexOf(s2);
				if (index >= 0)
					Console.WriteLine("'{0} begins at character position {1}",
								  s2, index + 1);
			}
		}

		private void WizardGenerator_Click(object sender, EventArgs e)
		{
			
			string SocietalRole = HeirarchyList.SelectedItem.ToString();
			string JobRole = JobListBox.SelectedItem.ToString();
			string Character = "You are a " + string.Concat(SocietalRole, " who works as a ", JobRole);
			wizard = new Wizard(nameBox.Text);

			int cha = 8;
			int wis = 9;
			int str = 5;
			int intel = 10;
			int dex = 6;

			try
			{
				if (HeirarchyList.SelectedItem == null)
				{
					MessageBox.Show("Error, please select one option from each category.");
				}

				if (JobListBox.SelectedItem == null)
				{
					MessageBox.Show("Error, please select one option from each category.");
				}
				if (SocietalRole == "Noble")
				{
					cha = cha + 1;
					wis = wis + 1;
					str = str - 2;
					intel = intel + 3;
					dex = dex + 0;
				}

				else if (SocietalRole == "Commoner")
				{
					cha = cha + 3;
					wis = wis + 1;
					str = str + 1;
					intel = intel + 1;
					dex = dex + 1;
				}

				else if (SocietalRole == "Peasant")
				{
					cha = cha - 1;
					wis = wis + 4;
					str = str + 2;
					intel = intel + 0;
					dex = dex + 2;
				}

				if (JobRole == "Royal Advisor")
				{
					cha = cha + 2;
					wis = wis + 3;
					str = str - 1;
					intel = intel + 2;
					dex = dex - 2;
				}

				else if (JobRole == "Blacksmith")
				{
					cha = cha + 1;
					wis = wis + 1;
					str = str + 3;
					intel = intel + 0;
					dex = dex + 4;
				}

				else if (JobRole == "Soldier")
				{
					cha = cha - 2;
					wis = wis - 1;
					str = str + 2;
					intel = intel + 1;
					dex = dex + 1;
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

			//input the total gold and strength
			chaBox.Text = cha.ToString();
			wisBox.Text = wis.ToString();
			strBox.Text = str.ToString();
			intBox.Text = intel.ToString();
			dexBox.Text = dex.ToString();

			//Give your character random lucks
			Random rand = new Random();
			int luck = rand.Next(1, 5);

			luckBox.Text = luck.ToString();

			using (var writer = new StreamWriter(@"CharacterSheet.txt"))

			{
				MessageBox.Show("Sheet Created. Please Access CharacterSheet.txt in the bin>debug.");
				writer.WriteLine("Your Character, " + wizard.Name + " has been created. Here are your Stats.");
				writer.WriteLine("Charisma: " + cha.ToString());
				writer.WriteLine("Wisdom: " + wis.ToString());
				writer.WriteLine("Strength: " + str.ToString());
				writer.WriteLine("Intellegence:  " + intel.ToString());
				writer.WriteLine("Dexterity " + dex.ToString());
				writer.WriteLine("Luck is " + luck.ToString());
				writer.WriteLine(Character + " known as " + wizard.Name);
				writer.Close();
			}

		}

		private void nameBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void JobListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}