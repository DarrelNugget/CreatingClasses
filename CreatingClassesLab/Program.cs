using System;

namespace CreatingClassesLab
{
    class Person
    {  
            public int personId;
            public String firstName;
            public String lastName;
            public String favoriteColour;
            public int age;
            public bool isWorking;

        public void DisplayPersonInfo()
        {
            Console.WriteLine("Name= " + firstName + " " + lastName);
            Console.WriteLine("Person ID= " + personId);
            Console.WriteLine("Favorite Colour= " + favoriteColour);
        }

        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";

        }

        public int GetAgeInTenYears()
        {
            return age + 10;
        }

        public override string ToString()
        {
            return "Person ID: " + personId + "\n" + "First Name: " + firstName + "\n" + "Last Name: " + lastName + "\n" + "Favorite Colour: " + favoriteColour + "\n" + "Age: " + age + "\n" + "Is Working: " + isWorking;
        }
    }

    class Relation
    {
        public String RelationshipType;

        public void ShowRelationship(Person person1, Person person2)
        {
            Console.WriteLine("Relationship between " + person1.firstName + " " + person1.lastName + " and " + person2.firstName + " " + person2.lastName + " is " + RelationshipType);
        }
    }

    class MainC
    {
        static void Main(string[] args)
        {
            //Ian
            Person person1 = new Person();
            person1.personId = 1;
            person1.firstName = "Ian";
            person1.lastName = "Brooks";
            person1.favoriteColour = "Red";
            person1.age = 30;
            person1.isWorking = true;
            //Gina
            Person person2 = new Person();
            person2.personId = 2;
            person2.firstName = "Gina";
            person2.lastName = "James";
            person2.favoriteColour = "Green";
            person2.age = 18;
            person2.isWorking = false;
            //Mike
            Person person3 = new Person();
            person3.personId = 3;
            person3.firstName = "Mike";
            person3.lastName = "Briscoe";
            person3.favoriteColour = "Blue";
            person3.age = 45;
            person3.isWorking = true;
            //Mary
            Person person4 = new Person();
            person4.personId = 4;
            person4.firstName = "Mary";
            person4.lastName = "Beals";
            person4.favoriteColour = "Yellow";
            person4.age = 28;
            person4.isWorking = true;

            //Display Gina
            Console.WriteLine(person2.firstName + " " + person2.lastName + "'s favorite colour is " + person2.favoriteColour);
            //Mike Infomation List
            Console.WriteLine(person3.ToString());
            //Change Ian Fav Colour
            person1.ChangeFavoriteColour();
            Console.WriteLine("Ian Brooks's favorite colour is: " + person1.favoriteColour);
            //Mary age after 10 Years
            int Age10YearsMary = person4.GetAgeInTenYears();
            Console.WriteLine("Mary Beaks's Age in 10 years is: " + Age10YearsMary);
            //Relation
            Relation relation1 = new Relation();
            relation1.RelationshipType = "Sisterhood";
            Relation relation2 = new Relation();
            relation2.RelationshipType = "Brotherhood";

            relation1.ShowRelationship(person2, person4);
            relation2.ShowRelationship(person1, person3);
            //List of Person 
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            //Average Age
            int totalAge = 0;
            foreach (Person person in people)
            {
                totalAge += person.age;
            }
            double averageAge = (double)totalAge / people.Count;
            Console.WriteLine("Average age is: " + averageAge);
            //Find the youngest and oldest
            Person youngest = people[0];
            Person oldest = people[0];
            foreach (Person person in people)
            {
                if (person.age < youngest.age)
                    youngest = person;
                if (person.age > oldest.age)
                    oldest = person;
            }
            Console.WriteLine("The youngest person is: " + youngest.firstName);
            Console.WriteLine("The oldest person is: " + oldest.firstName);
            //People with the first name M
            List<string> MNames = new List<string>();
            foreach (Person person in people)
            {
                if (person.firstName.StartsWith("M"))
                    Console.Write(person.ToString() + "\n");
            }
            //Find person like Blue
            Person favoriteColorBlue = null;
            foreach (Person person in people)
            {
                if (person.favoriteColour == "Blue")
                {
                    favoriteColorBlue = person;
                    break;
                }
            }
            Console.WriteLine(favoriteColorBlue.ToString());

        }
    }
}
