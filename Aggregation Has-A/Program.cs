using System;

namespace Aggregation_Has_A
{
    class Address
    {
        private int houseNo;
        private string houseName;
        private int pincode;

        public Address(int houesNo,string houesName,int pincode)
        {
            this.houseNo = houesNo;
            this.houseName = houesName;
            this.pincode = pincode;
        }
        public override string ToString()
        {
            return this.houseNo + " " + this.houseName + " " + this.pincode;
        }
    }
    class Employee 
    {
        private int empNo;
        private string empName;
        private Address empAddress;
        

        public Employee(int empNo,string empName,Address empAddress)
        {
            this.empNo = empNo;
            this.empName = empName;
            this.empAddress = empAddress;
        }
    public void showRecorde()
        {
            Console.WriteLine(empNo + " " + empName + " " + empAddress);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //        Address A = new Address(111, "ram", 1313);

            /* Employee obj = new Employee(111, "ak", Employee.Address);
             obj.showRecorde();*/
            Console.Write("Enter the EmpNo: ");
            int EmpNO = int.Parse(Console.ReadLine());

            Console.Write("Enter the EmpNAME: ");
            string EmpNAME = Console.ReadLine();
            Console.Write("Enter the houseNO: ");
            int houseNO = int.Parse(Console.ReadLine());
            Console.Write("Enter the houseNAME: ");
            string houseNAME = Console.ReadLine();
            Console.Write("Enter the housePINCODE : ");
            int housePINCODE = int.Parse(Console.ReadLine());

            //  Employee obj = new Employee(111, "ak", new Address(22,"sector 59",121331));
            Employee obj = new Employee(EmpNO, EmpNAME, new Address(houseNO, houseNAME, housePINCODE));
            obj.showRecorde();
        }
    }
}
