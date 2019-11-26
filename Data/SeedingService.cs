using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcAppContext _context; // o mesmo nome da classe onde está os get's e set's que vão construir no banco de dados


        /*
         * construtor para construir no banco de dados as informações.
         */

        public SeedingService(SalesWebMvcAppContext context)
        {
            _context = context;
        }

        public void Seed()
        { //verifica se ja existe algum dado na base de dados, se existir não fazer nada.
          //o metodo Any() faz parte da verificação se existe algum coisa no banco de dados. // determina se um sequencia tem elementos 
          /*
           * Todos eles fazem a mesma coisa - verificar se um elemento existe numa determinada coleção de elementos - de maneiras diferentes.

            Any() veio com o Linq, funciona com qualquer coleção enumerável e recebe Func<T, bool> como parâmetro. O Any() também tem uma versão sem parâmetro nenhum que verifica se a coleção contém algum elemento, ou seja, se Count > 0.

            Exists() funciona apenas com List<T> e recebe um Predicate<T> como parâmetro - isso permite que sejam feitas duas ou mais validações. Ex.: lista.Exists(x => x == 1 || x == 2);

            Contains() também funciona apenas com List<T>, mas ao invés de receber um Predicate<T> recebe um elemento (T) como parâmetro.

            Supondo que você tem uma lista de inteiros

            var lista = new List<int> {1, 2, 3, 4, 5}; 
            Any()
            É um método de extensão do namespace System.Linq. Veio com o .NET Framework 3.5 e funciona com qualquer coleção que seja "enumerável". Recebe Func<T, bool> como parâmetro (na prática é a mesma coisa que receber Predicate<T>).

            Ex. de uso (verificar se existem os elementos 2 ou 3):

            bool exists = lista.Any(x => x == 2 || x == 3);
            Contains()
            Método default de List<T>. Recebe um elemento como parâmetro.

            Ex. de uso (verificar se existe o elemento 1):

            bool exists = lista.Contains(1);
            Exists()
            Também é um método default de List<T>. A única diferença dele pro Contains é que ele recebe um Predicate<T> como parâmetro, ao invés de receber um elemento. Ele existe basicamente para que não seja necessário fazer vários Contains() quando precisar verificar a existência de mais de um elemento numa lista.

            Ex. de uso (verificar se existem os elementos 1 ou 3):

            bool exists = lista.Exists(x => x == 1 || x == 3);
           * 
           */
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {
                return; //DB has been seeded
            }

            // somente no metodo CODE-FIRST Workflow

            
            Department d1 = new Department(1, "Computer");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Qualquer");
            Department d4 = new Department(4, "TESTE");
            Department d6 = new Department(6,  "Notqualquer");
            Department d5 = new Department(5 , "Book");
                        
            /*
             * para fazer um conjunto de codigo pareceido é so precionar shift + alt + seta
             */

            // Vendedores 
            Seller s1  = new Seller (1, "Afonso Rafael", "qualquer@gmail.com", new DateTime (1990, 12, 17), 5000.0, d1);
            Seller s2  = new Seller (1, "Afonso Rafael", "quluer@gmail.com", new DateTime(1990, 12, 01), 3000.0, d2);
            Seller s3  = new Seller (1, "Afonso Rafael", "qualer@gmail.com", new DateTime(1990, 12, 07), 2000.0, d3);
            Seller s4  = new Seller (1, "Afonso Rafael", "asdf@gmail.com", new DateTime(1990, 12, 18), 1000.0, d6);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);


            // registros de vendas
            SalesRecord sr1 = new SalesRecord (1, new DateTime(2018, 09, 25), 2000.0, SaleStatus.Billed, s1 );
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);
            SalesRecord sr31 = new SalesRecord(31, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);

            //Colocar os objetos no banco de dados com EntityFramewor
            // AddRange -> permite adicionar varios objetos de uma só vez

            _context.Department.AddRange(d1, d2,d3,d4,d5,d6);

            _context.Seller.AddRange(s1,s2,s3,s4,s5,s6);

            _context.SalesRecords.AddRange(sr1,sr2,sr3,sr4,sr5,sr6,sr7 , sr8, sr9, sr10, sr11, sr12, sr13, sr14, sr15, sr16,
                                           sr17, sr18, sr19, sr20, sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30);

            // para salvar as alterações no banco de dados.

            _context.SaveChanges();

        }
    } 



}
