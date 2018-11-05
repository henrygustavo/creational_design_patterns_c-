namespace CreationalDesignPatterns.Test
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using System.Diagnostics;
    using Entities.ProtoType;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProtoTypeTest
    {
        [TestMethod]
        public void TestVersion01()
        {
            Registry registry = new Registry();
            Movie movie = (Movie)registry.CreateItem("Movie");
            movie.Title = "Creational Patterns in c#";
            Debug.WriteLine(movie);
            Debug.WriteLine(movie.Runtime);
            Debug.WriteLine(movie.Title);
            Debug.WriteLine(movie.Price);

            Debug.WriteLine("*******************************************");

            Movie anotherMovie = (Movie)registry.CreateItem("Movie");
            anotherMovie.Title = "Gang of Four";
            Debug.WriteLine(anotherMovie);
            Debug.WriteLine(anotherMovie.Runtime);
            Debug.WriteLine(anotherMovie.Title);
            Debug.WriteLine(anotherMovie.Price);
        }

        [TestMethod]
        public void TestVersion02()
        {

            List<Permission> supervisorPermissions = GetPermissionsFromFile("supervisor.txt");
            UserAccount supervisor = new UserAccount {Permissions = supervisorPermissions};

            List<Permission> accountRepPermissions = GetPermissionsFromFile("accountrep.txt");
            UserAccount accountRep = new UserAccount {Permissions = accountRepPermissions};

            AccountPrototypeFactory factory = new AccountPrototypeFactory(supervisor, accountRep);

            UserAccount newSupervisor = factory.Supervisor;
            newSupervisor.UserName = "PKuchana";
            newSupervisor.Password = "Everest";
            Debug.WriteLine(newSupervisor);

            UserAccount anotherSupervisor = factory.Supervisor;
            anotherSupervisor.UserName = "SKuchana";
            anotherSupervisor.Password = "Everest";
            Debug.WriteLine(anotherSupervisor);

            UserAccount newAccountRep = factory.AccountRep;
            newAccountRep.UserName = "VKuchana";
            newAccountRep.Password = "Vishal";
            Debug.WriteLine(newAccountRep);
        }


        [TestMethod]
        public void TestVersion03()
        {
            List<Language> list = new List<Language> {new Language("C++"), new Language("JAVA")};

            List<Language> shallow = new List<Language>(list);

            Debug.WriteLine("shallow: " + list.SequenceEqual(shallow));

            for (int i = 0; i < list.Count; i++)
            {
                Debug.WriteLine(" * shallow: " + list[i].Equals(shallow[i])); //true
            }

            List<Language> deep = new List<Language>();
            foreach (Language language in list)
            {
                deep.Add((Language)language.Clone());
            }

            Debug.WriteLine("deep: " + list.SequenceEqual(deep));

            for (int i = 0; i < list.Count; i++)
            {
                Debug.WriteLine(" * deep: " + list[i].Equals(deep[i])); //false
            }

            list[0].Name = "PYTHON";
            Debug.WriteLine("Shallow [0]: " + shallow[0].Name);
            Debug.WriteLine("Shallow [1]: " + shallow[1].Name);
            Debug.WriteLine("Deep: [0]" + deep[0].Name);
            Debug.WriteLine("Deep: [1]" + deep[1].Name);
        }

        private  List<Permission> GetPermissionsFromFile(string fileName)
        {
            List<Permission> permissions = new List<Permission>();
            try
            {
           
                StreamReader br = new StreamReader($@"Data\{fileName}");

                string inputLine;
                while (!string.ReferenceEquals((inputLine = br.ReadLine()), null))
                {
                    var st = inputLine.Split(",");
                    string resource = st[0];
                    string permission = st[1];
                    permissions.Add(new Permission(resource, permission));
                }
                br.Close();
            }
            catch (FileNotFoundException)
            {
            }
            catch (IOException)
            {
            }
            return permissions;
        }
    }
}
