
namespace TestApp
{
    using GRKAdminCore;
    using System;
    using System.ComponentModel;

    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new LDEntities())
            {
                LDTABLE t = new LDTABLE()
                {
                    ID=1059,
                    Name = "testtable_entity_2",
                    CardTable = "-",
                    GUIView = "+",
                    Type = "U",
                    DisplayLabel = "Тестовая таблица EF",
                    Deleted = "-"
                };
                context.LDTABLE.Add(t);
                context.SaveChanges();
            }
            
        }
    }

    public class TestTableDF
    {
        public int ID { get; set; }
        [DisplayName("First Name")]
        public string Fname { get; set; }
        [DisplayName("Surname")]
        public string Sname { get; set; }
    }
}