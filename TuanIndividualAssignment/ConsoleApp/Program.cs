// See https://aka.ms/new-console-template for more information
using System.Text;
namespace ConsoleApp
{
    class Program
    {
        class Test
        {
            public class MainApp()
            {
                public static void Main(String[] args)
                {
                    ContractBuilder builder;
                    Client client = new Client();
                    builder = new Permanent();
                    client.requestCreateRentalContract(builder);
                    builder.Contract.Show();

                    builder = new LongTerm();
                    client.requestCreateRentalContract(builder);
                    builder.Contract.Show();

                    builder = new ShortTerm();
                    client.requestCreateRentalContract(builder);
                    builder.Contract.Show();

                    Console.ReadKey();
                }
            }

            class Client
            {
                public void requestCreateRentalContract(ContractBuilder builder)
                {
                    builder.BuildContractID();
                    builder.BuildPropertyID();
                    builder.BuildTenantID();
                    builder.BuildRentAmount();
                }
            }

            abstract class ContractBuilder
            {
                protected Contract contract;

                public Contract Contract
                {
                    get { return contract; }
                }

                public abstract void BuildContractID();
                public abstract void BuildPropertyID();
                public abstract void BuildTenantID();
                public abstract void BuildRentAmount();
            }

            class Permanent : ContractBuilder
            {
                public Permanent()
                {
                    contract = new Contract("Permanent");
                }

                public override void BuildContractID()
                {
                    contract["ContractID"] = "111";
                }

                public override void BuildPropertyID()
                {
                    contract["PropertyID"] = "123";
                }

                public override void BuildTenantID()
                {
                    contract["TenantID"] = "123";
                }

                public override void BuildRentAmount()
                {
                    contract["RentAmount"] = "infinite";
                }
            }

            class LongTerm : ContractBuilder
            {
                public LongTerm()
                {
                    contract = new Contract("LongTerm");
                }

                public override void BuildContractID()
                {
                    contract["ContractID"] = "111";
                }

                public override void BuildPropertyID()
                {
                    contract["PropertyID"] = "123";
                }

                public override void BuildTenantID()
                {
                    contract["TenantID"] = "123";
                }

                public override void BuildRentAmount()
                {
                    contract["RentAmount"] = "more than 2 years";
                }
            }

            class ShortTerm : ContractBuilder
            {
                public ShortTerm()
                {
                    contract = new Contract("ShortTerm");
                }

                public override void BuildContractID()
                {
                    contract["ContractID"] = "111";
                }

                public override void BuildPropertyID()
                {
                    contract["PropertyID"] = "123";
                }

                public override void BuildTenantID()
                {
                    contract["TenantID"] = "123";
                }

                public override void BuildRentAmount()
                {
                    contract["RentAmount"] = "less than 2 years";
                }
            }
            class Contract
            {
                private string _contractType;
                private Dictionary<string, string> _contract = new Dictionary<string, string>();

                public Contract(string contractType)
                {
                    this._contractType = contractType;
                }

                public string this[string key]
                {
                    get { return _contract[key]; }
                    set { _contract[key] = value; }
                }

                public void Show()
                {
                    Console.WriteLine("\n---------------------------");
                    Console.WriteLine("Contract Type: {0}", _contractType);
                    Console.WriteLine("Contract ID: {0}", _contract["ContractID"]);
                    Console.WriteLine("Property ID: {0}", _contract["PropertyID"]);
                    Console.WriteLine("Tenant ID: {0}", _contract["TenantID"]);
                    Console.WriteLine("Rent Amount: {0}", _contract["RentAmount"]);
                }
            }

        }
    }
}
