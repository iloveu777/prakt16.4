using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp1
{
    class Sotryd
    {
        int id { get; set; }
        string name { get; set; }
        string surname { get; set; }
        DateTime birth { get; set; }
        string job_title { get; set; }
        int zp { get; set; }
        DateTime data { get; set; }
        string sex { get; set; }
        public Sotryd() { }
        public Sotryd(int _id, string _name, string _surname,string _sex , DateTime _birth, string job_titlee, int _zp, DateTime _data)
        {
            id = _id;
            name = _name;
            surname = _surname;
            sex = _sex; 
            birth = _birth;
            job_title = job_titlee;
            zp = _zp;
            data = _data;

        }
        public void Input() 
        {
            Write("Введите ID: ");
            id = int.Parse(ReadLine());
            Write("Введите имя: ");
            name = ReadLine();
            Write("Введите фамилию: ");
            surname = ReadLine();
            Write("Введите пол(м или ж): ");
            sex = Read();
            Write("Введите дату рождения(гггг.мм.дд): ");
            birth= DateTime.Parse(ReadLine());
            Write("Введите должность: ");
            job_title= ReadLine();
            Write("Введите З/П: ");
            zp = int.Parse(ReadLine());
            Write("Введите дату поступления на работу(гггг.мм.дд): ");
            data = DateTime.Parse(ReadLine());
        }
        public void Print()
        {
            WriteLine($"{id} | {name} | {surname} | {birth:d} | {job_title} | {zp}");
        }
        public void PrintAge()
        {
            int age = DateTime.Now.Year - birth.Year;
            if (DateTime.Now < birth.AddYears(age)) age--;
            WriteLine($"Полных лет - {age}");

        }
        public void CheckDaysWork()
        {
            TimeSpan aa = DateTime.Today.Subtract(data);
            WriteLine($"Кол-во отработанных дней сотрудника с ID {id} - {aa.Days} ");
        }
        public void Pens()
        {
            
            TimeSpan aa = DateTime.Today.Subtract(data); 
            int age = DateTime.Now.Year - birth.Year;
            if (DateTime.Now < birth.AddYears(age)) age--;
            if (age >= 55 || aa >= )
            {
                Write($"Сотрудник {id}) {name} {surname} находится на пенсии ");
            }
        
        
        }
        //добавить поле "дата поступления на работу" и определить  кол-во отработанных дней на предприятии, сотрудники на пенсии (>60)
    }
}
