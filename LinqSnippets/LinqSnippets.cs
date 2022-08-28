namespace LinqSnippets
{
    public class LinqSnippets
    {
        static public void BasicLinQ()
        {
            string[] carList =
            {
                "VW Golf",
                "VW California",
                "BMW 320",
                "BMW M3",
                "BMW X1",
                "Fiat Panda",
                "Fiat Punto"
            };

            // 1. SLEECT * of cars
            var allCars = from car in carList select car;

            Console.WriteLine("\n");
            Console.WriteLine(string.Concat(Enumerable.Repeat('*', 50)));
            Console.WriteLine("Print all Cars:\n ");

            foreach (var car in allCars) Console.WriteLine(car);

            // 1. SLEECT WHERE car is an BMW
            var bmwCars = from car in carList
                          where car.Contains("BMW")
                          select car;

            Console.WriteLine("\n");
            Console.WriteLine(string.Concat(Enumerable.Repeat('*', 50)));
            Console.WriteLine("Print BMW Cars:\n ");

            foreach (var car in bmwCars) Console.WriteLine(car);

        }

        static public void LinqNumbers()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("\n");
            Console.WriteLine(string.Concat(Enumerable.Repeat('*', 50)));
            Console.WriteLine("Procesar numeros con linQ:\n ");
            Console.WriteLine("\n");
            Console.WriteLine("Numeros sin procesar:\n ");
            foreach (var num in numbers) Console.WriteLine(num);
            // Each Number multiplied by 3
            // take all numbers, but 9
            // Order numbers by ascendic value

            var processedNumbers = numbers.Select(n => n * 3)
                            .Where(n => n != 9)
                            .OrderBy(n => n);

            Console.WriteLine("\n");
            Console.WriteLine("Numeros procesados:\n ");
            foreach (var num in processedNumbers) Console.WriteLine(num);
        }

        static public void SearchExemples()
        {
            List<string> textList = new List<string>()
            {
                "a",
                "bx",
                "c",
                "d",
                "e",
                "fx",
                "c"
            };

            Console.WriteLine("\n");
            Console.WriteLine(string.Concat(Enumerable.Repeat('*', 50)));
            Console.WriteLine("Busquedas con linQ:\n ");

            // 1. First of all elemnts
            var firstElement = textList.First();
            Console.WriteLine($"Primer elemento: {firstElement}");

            // 2. First element that is "c"
            var firstC = textList.First(t => t.Equals("c"));
            Console.WriteLine($"Primer elemento que es igual a c: {firstC}");

            // 3. First element that contains x
            var firstX = textList.First(t => t.Contains("x"));
            Console.WriteLine($"Primer elemento que contiene x: {firstX}");

            // 4. First element that contains "z" or deflt
            var firstZdefault = textList.FirstOrDefault(t => t.Contains("z"));
            Console.WriteLine($"Primer elemento que contiene z o default: {string.IsNullOrEmpty(firstZdefault)}");

            // 5. Last element that contains "z" or deflt
            var LastZdefault = textList.LastOrDefault(t => t.Contains("z"));
            Console.WriteLine($"Último elemento que contiene z o default: {string.IsNullOrEmpty(LastZdefault)}");

            // 6. Single Values
            string singleValue = null;
            Console.WriteLine($"Uso de single: {singleValue}");
            try
            {
                singleValue = textList.Single();
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("La lista contiene más de un elemento.");
            }

            string singleValueOrDef = string.Empty;
            Console.WriteLine("La lista contiene más de un elemento. Devolver Default: {0}", string.IsNullOrEmpty(singleValueOrDef));

            // 7. Obtain {4, 8}
            int[] evenNumbers = { 0, 2, 4, 6, 8 };
            int[] othersEvenNumbers = { 0, 2, 6 };

            Console.WriteLine("Obtener el {4, 8}");

            var myEvenNums = evenNumbers.Except(othersEvenNumbers);
            foreach (var n in myEvenNums) Console.WriteLine(n);
        }

        static public void MultipleSelect()
        {
            string[] myOpinion =
            {
                "Opinion 1, Texto 1",
                "Opinion 2, Texto 2",
                "Opinion 3, Texto 3",
            };

            var myOpinionSelect = myOpinion.SelectMany(opinion => opinion.Split(","));

            foreach (var n in myOpinionSelect)
            {
                Console.WriteLine(n);
                //Console.WriteLine(n.Trim(' '));
            }
        }

        static public void LinQConObjetos()
        {
            Console.WriteLine("\n");
            Console.WriteLine(string.Concat(Enumerable.Repeat('*', 50)));
            Console.WriteLine("Uso de linQ con objetos:\n ");
            var enterprises = new[]
            {
                new Enterprise()
                {
                    Id = 1,
                    Name = "Mercadona",
                    EmployeeList = new[]
                    {
                        new Employee(){ Id = 1, Name = "Axel", Email = "axel@gmail.com", Salary = 22000},
                        new Employee(){ Id = 2, Name = "Manuel", Email = "manuel@gmail.com", Salary = 20000},
                        new Employee(){ Id = 3, Name = "Kike", Email = "kike@hotmail.com", Salary = 16000},
                    }
                },
                new Enterprise()
                {
                    Id = 2,
                    Name = "Alcampo",
                    EmployeeList = new[]
                    {
                        new Employee(){ Id = 1, Name = "Luis", Email = "luis@hotmail.com", Salary = 24000},
                        new Employee(){ Id = 2, Name = "Pol", Email = "pol@gmail.com", Salary = 17000},
                        new Employee(){ Id = 3, Name = "Pedro", Email = "pedr@hotmail.com", Salary = 16000},
                    }
                },
                 new Enterprise()
                {
                    Id = 3,
                    Name = "Telecinco",
                    //EmployeeList = Array.Empty<Employee>()
                    EmployeeList = new[]
                    {
                        new Employee(){ Id = 1, Name = "Julian", Email = "julia@gmail.com", Salary = 31000},
                        new Employee(){ Id = 2, Name = "Rafa", Email = "rafa@gmail.com", Salary = 17000},
                        new Employee(){ Id = 3, Name = "Belen", Email = "belen@hotmail.com", Salary = 40000},
                    }
                 }
            }; // FIn creación objetos

            // 1. Get all employees of all enterpises
            var allEmployees = enterprises.SelectMany(ent => ent.EmployeeList);

            Console.WriteLine("Get all employees of all enterpises:\n ");
            foreach (var employee in allEmployees) Console.WriteLine(employee.Name);

            // 2. Know if any is empty
            var hasEmployees = enterprises.Any(ent => ent.EmployeeList.Count() == 0);

            Console.WriteLine($"ALguna empresa sin empleados {hasEmployees}");

            // 3. All enterprises at least employee whit more than 23.000d salary
            bool hasEmployeeMoreThan23k =
                enterprises.All(enter =>
                    enter.EmployeeList.All(employee =>
                        employee.Salary >= 16000
                        )
                );
            Console.WriteLine($"Todas las empresas tienen empleados con sueldo igual o mayor a 23k: {hasEmployeeMoreThan23k}");

        }

        public static void linQColLections()
        {
            Console.WriteLine("\n");
            Console.WriteLine(string.Concat(Enumerable.Repeat('*', 50)));
            Console.WriteLine("Uso de linQ y listas (JOIN):\n ");

            var firstList = new List<string>() { "a", "b", "c", "d", "4", "9" };
            var secondList = new List<string>() { "a", "c", "d", "e", "x" };

            // INNER JOIN
            var commonResult = from item in firstList
                               join item2 in secondList
                               on item equals item2
                               select item;

            Console.WriteLine("Generando inner join: ");
            foreach (var common in commonResult) Console.WriteLine(common);
            Console.WriteLine("");

            // OUTER JOIN LEFT
            var leftResult = from item in firstList
                             join item2 in secondList
                             on item equals item2
                             into tempList
                             from temp in tempList.DefaultIfEmpty()
                             where item != temp
                             select item;

            Console.WriteLine("Generando OUTER JOIN LEFT: ");
            foreach (var leftJoin in leftResult) Console.WriteLine(leftJoin);
            Console.WriteLine("");

            // OUTER JOIN RIGHT
            var rightResult = from item2 in secondList
                              join item in firstList
                              on item2 equals item
                              into tempList
                              from temp in tempList.DefaultIfEmpty()
                              where item2 != temp
                              select item2;

            Console.WriteLine("Generando OUTER JOIN RIGHT: ");
            foreach (var item in rightResult) Console.WriteLine(item);
            Console.WriteLine("");



        }
    }
}