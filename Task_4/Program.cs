class Person{

    string Name {get;}
    string Surname {get;}
    DateTime Date_of_birth{get;}
    int Height{get;}

    //конструктор класса
    public Person(string name, string surname, DateTime date_of_birth, int height){

        Name = name;
        Surname = surname;
        Date_of_birth = date_of_birth;
        Height = height;

    }
    //метод для вывода полей
    public void Print_Person(){

        Console.WriteLine($"Имя: {Name},  Фамилия: {Surname}, Дата рождения: {Date_of_birth}, Рост: {Height}");

    }

}

class Program{
    static void Main(string[] args){

        Person Daniel = new Person("Данил","Назмутдинов",new DateTime(2005, 07, 07,11,43,33), 181); //Создание экземпляра класса
        Daniel.Print_Person();

    }
}