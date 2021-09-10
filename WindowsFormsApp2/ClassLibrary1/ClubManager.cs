using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SwimManagementSystem
{
    public class ClubsManager : IClubsRepository
    {
        public List<Club> Clubs { get; } = new List<Club>();
        public void AddClub(Club aClub)
        {
            this.Clubs.Add(aClub);
        }
        private string formatRecord(Club aClub, string delimiter)
        {
            if (aClub.ClubNumber == 0 || String.IsNullOrEmpty(aClub.Name) || aClub.PhoneNumber == 0)
            {
                return null;
            }
            else
            {
                string result = string.Format(aClub.ClubNumber + delimiter + aClub.Name + delimiter + aClub.ClubAddress + delimiter + aClub.PhoneNumber);
                return result;
            }
        }
        public Club GetClub(uint regNumber)
        {
            foreach(var club in this.Clubs)
            {
                if (club.ClubNumber == regNumber) return club;
            }
                return null;
            
        }
        public void LoadClubs(string fileName, string delimiter)
        {
            delimiter = ",";
            try
            {
                TextReader reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] values = line.Split(delimiter.ToCharArray());
                    uint regNumber = Convert.ToUInt32(values[0]);
                    string clubName = values[1];
                    string street = values[2];
                    string city = values[3];
                    string province = values[4];
                    string postCode = values[5];
                    ulong phoneNumber = Convert.ToUInt64(values[6]);
                    Address anAddress = new Address(street, city, province, postCode);
                    Club club = new Club(regNumber, clubName, anAddress, phoneNumber);
                    this.Clubs.Add(club);
                    line = reader.ReadLine();

                }
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file or directory cannot be found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file or directory cannot be found.");
            }
            catch (DriveNotFoundException)
            {
                Console.WriteLine("The drive specified in 'path' is invalid.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("'path' exceeds the maxium supported path length.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have permission to create this file.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 32)
            {
                Console.WriteLine("There is a sharing violation.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 80)
            {
                Console.WriteLine("The file already exists.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An exception occurred:\nError code: " +
                                  $"{e.HResult & 0x0000FFFF}\nMessage: {e.Message}");
            }       
           

            
        }
        private Club ProcessClubRecording(string aRecord, string delimiter)
        {

            string[] values = aRecord.Split(delimiter.ToCharArray());
            uint regNumber = Convert.ToUInt32(values[0]);
            string clubName = values[1];
            string street = values[2];
            string city = values[3];
            string province = values[4];
            string postCode = values[5];
            string number = values[6];
            if (!number.All(char.IsDigit))
            {
                throw new Exception("Invalid club record. Phone number wrong format");
            }
            ulong phoneNumber = Convert.ToUInt64(number);
            if (values.Length < 7)
            {
                throw new Exception("Invalid club record. Not enough fields");
            }
            if(regNumber == 0)
            {
                throw new Exception("Invalid club record Club number is not valid");
            }
            if (String.IsNullOrEmpty(clubName))
            {
                throw new Exception("Invalid club record. Club name is not valid");
            }
            foreach (var club in Clubs)
            {
                if (club.ClubNumber == regNumber)
                {
                    throw new Exception("Invalid club record. Club with this registration number already exists.");
                }
            }
            Address address1 = new Address(street, city, province, postCode);
            Club club1 = new Club(regNumber, clubName, address1, phoneNumber);
            return club1;
            
        }
        public void SaveClubs(string fileName, string delimiter)
        {
            try
            {
                TextWriter writer = new StreamWriter(fileName);
                foreach (var club in Clubs)
                {
                    formatRecord(club, ",");
                }
                writer.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file or directory cannot be found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file or directory cannot be found.");
            }
            catch (DriveNotFoundException)
            {
                Console.WriteLine("The drive specified in 'path' is invalid.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("'path' exceeds the maxium supported path length.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have permission to create this file.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 32)
            {
                Console.WriteLine("There is a sharing violation.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 80)
            {
                Console.WriteLine("The file already exists.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An exception occurred:\nError code: " +
                                  $"{e.HResult & 0x0000FFFF}\nMessage: {e.Message}");
            }

        }


    }
}
