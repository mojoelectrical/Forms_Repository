using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SwimManagementSystem
{
    public class SwimmersManager : ISwimmersRepository
    {
        public IClubsRepository ClubsManager { get; set; }
        public List<Swimmer> Swimmers { get; } = new List<Swimmer>();
        public void AddSwimmer(Swimmer aSwimmer)
        {
            this.Swimmers.Add(aSwimmer);
            if(aSwimmer.Club != null && ClubsManager.GetClub(aSwimmer.Club.ClubNumber) == null)
            {
                this.ClubsManager.AddClub(aSwimmer.Club);
            }
        }
        public string formatRecord(Registrant aSwimmer, string delimiter)
        {
            if(aSwimmer.Id == 0 || String.IsNullOrEmpty(aSwimmer.Name) || aSwimmer.DateOfBirth == null || aSwimmer.PhoneNumber == 0 || ClubsManager.GetClub(aSwimmer.Club.ClubNumber) == null)
            {
                return null;
            }else
            {
                string result = string.Format(aSwimmer.Id + delimiter + aSwimmer.Name + delimiter + aSwimmer.DateOfBirth + delimiter + aSwimmer.Address + delimiter + aSwimmer.PhoneNumber + delimiter + aSwimmer.Club.ClubNumber);
                return result;
            }

        }
        public Swimmer GetSwimmer(uint regNumber)
        {
            foreach(var swimmer in Swimmers)
            {
                if (swimmer.Id == regNumber) return swimmer;
            }
            return null;
        }
        public void LoadSwimmers(string fileName, string delimiter)
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
                    DateTime dateOfBirth = Convert.ToDateTime(values[2]);
                    string name = values[1];
                    string street = values[3];
                    string city = values[4];
                    string province = values[5];
                    string postCode = values[6];
                    ulong phoneNumber = Convert.ToUInt64(values[7]);
                    Address anAddress = new Address(street, city, province, postCode);
                    Swimmer swimmer = new Swimmer(name, dateOfBirth, anAddress, phoneNumber);
                    Swimmers.Add(swimmer);
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
            catch(System.FormatException)
            {
                Console.WriteLine("The string is not in the right format");
            }



        }
        private Swimmer processSwimmingRecord(string aRecord, string delimiter)
        {
            string[] values = aRecord.Split(delimiter.ToCharArray());
            string number = values[0];
            if(!number.All(char.IsDigit))
            {
                throw new Exception("Invalid swim record. Invalid registration number. ");
            }
            uint regNumber = Convert.ToUInt32(number);
            
            string birthDateString = values[1];
            string[] date = birthDateString.Split('-');
            if(date[0].Length != 4 && date[1].Length != 2 && date[2].Length != 2 || date == null)
            {
                throw new Exception("Invalid swimmer record. Invalid birth date format");
            }
            
            DateTime birthDate = Convert.ToDateTime(birthDateString);
            string name = values[2];
            string street = values[3];
            string city = values[4];
            string province = values[5];
            string postCode = values[6];
            
            string phoneNumberString = values[7];
            if (!phoneNumberString.All(char.IsDigit))
            {
                throw new Exception("Invalid club record. Phone number wrong format");
            }
            ulong phoneNumber = Convert.ToUInt64(phoneNumberString);
            if (values.Length > 8)
            {
                throw new Exception("Invalid swimmer record. Not enough fields");
            }
            if(regNumber == 0 )
            {
                throw new Exception("Invalid swim record. Invalid registration number");
            }
            if(string.IsNullOrEmpty(name))
            {
                throw new Exception("Invalid swimmer record. Invalid swimmer name");
            }
            foreach(var swimmer in Swimmers)
            {
                if(swimmer.Club.ClubNumber == regNumber)
                {
                    throw new Exception("Invalid swimmer record. Swimmer with the registration number already exists");
                }
            }
            foreach(var swimmer1 in Swimmers)
            {
                if(ClubsManager.GetClub(regNumber) == null)
                {
                    throw new Exception("Invalid swimmer record. Club affiliation exists but not valid");
                }

            }
        
            Address anAddress = new Address(street, city, province, postCode);
            Swimmer aSwimmer = new Swimmer(name,birthDate,anAddress,phoneNumber);
            return aSwimmer;
            
        }
        public void SaveSwimmers(string fileName, string delimiter)
        {
            try
            {
                TextWriter writer = new StreamWriter(fileName);
                foreach (var swimmer in Swimmers)
                {
                    formatRecord(swimmer, ",");
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
        public SwimmersManager(IClubsRepository manager)
        {
            ClubsManager = manager;
        }
    }
        
    }

