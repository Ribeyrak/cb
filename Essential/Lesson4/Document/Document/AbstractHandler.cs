using System;

namespace Document
{
    abstract class AbstractHandler
    {
        string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }
        void Open()
        {
            Console.WriteLine(fileName + " open");
        }
        void Create()
        {
            Console.WriteLine(fileName + " creat");
        }
        void Chenge()
        {
            Console.WriteLine(fileName + " chenge");
        }
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string fileName) : base(fileName)
        { }

        public override void Save()
        {
            Console.WriteLine(fileName + " сохранен в формате XML")
        }
    }

    class TXTHandler : AbstractHandler
    {

    }

    class DOCHandler : AbstractHandler
    {

    }
}
//Создайте класс AbstractHandler.
//В теле класса создать методы void Open() , void Create() , void Chenge() , void Save(). 
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
//Написать программу, которая будет выполнять определение документа и для каждого формата должны быть 
//методы открытия, создания, редактирования, сохранения определенного формата документа