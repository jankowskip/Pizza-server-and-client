using KontraktServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace TablicaServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress1 = new Uri("http://localhost:30030/Tablica");
       //     Uri baseAddress2 = new Uri("http://localhost:30030/Tablica");
      //      String baseAddress3 = "net.tcp://localhost:30031/TablicaTCP";
       //     Uri baseAddress4 = new Uri("http://localhost:30032/TablicaPipes");
       //     string address = "net.pipe://localhost/TablicaPipes";





            // Create a ServiceHost for the CalculatorService type and provide the base address. 
          


              
                ServiceHost mojHost = new ServiceHost(typeof(Tablica), baseAddress1);
                try
                {

                    ServiceEndpoint endpoint1 = mojHost.AddServiceEndpoint(typeof(ITablica), new WSHttpBinding(), "Tablica");
                //    ServiceEndpoint endpoint2 = mojHost.AddServiceEndpoint(typeof(ITablica), new WSHttpBinding(), "Tablica2");
                //    ServiceEndpoint endpoint3 = mojHost.AddServiceEndpoint(typeof(ITablica), new NetTcpBinding(), baseAddress3);
                //    NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
                //    ServiceEndpoint endpoint4 = mojHost.AddServiceEndpoint(typeof(ITablica), new NetNamedPipeBinding(), address);

                     ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;
                    mojHost.Description.Behaviors.Add(smb);
                 //   smb.HttpGetUrl = new Uri("http://localhost:30032/TablicaPipes");

                    Console.WriteLine("\nService endpoint {0} contains the following:", endpoint1.Name);
                    Console.WriteLine("Binding: {0}", endpoint1.Binding.ToString());
                    Console.WriteLine("Contract: {0}", endpoint1.Contract.ToString());
                    Console.WriteLine("ListenUri: {0}", endpoint1.ListenUri.ToString());
                    Console.WriteLine("ListenUriMode: {0}", endpoint1.ListenUriMode.ToString());

                //    Console.WriteLine("\nService endpoint {0} contains the following:", endpoint2.Name);
                //    Console.WriteLine("Binding: {0}", endpoint2.Binding.ToString());
                //    Console.WriteLine("Contract: {0}", endpoint2.Contract.ToString());
                //    Console.WriteLine("ListenUri: {0}", endpoint2.ListenUri.ToString());
                //    Console.WriteLine("ListenUriMode: {0}", endpoint2.ListenUriMode.ToString());

              //      Console.WriteLine("\nService endpoint {0} contains the following:", endpoint3.Name);
              //      Console.WriteLine("Binding: {0}", endpoint3.Binding.ToString());
               //     Console.WriteLine("Contract: {0}", endpoint3.Contract.ToString());
              //      Console.WriteLine("ListenUri: {0}", endpoint3.ListenUri.ToString());
              //      Console.WriteLine("ListenUriMode: {0}", endpoint3.ListenUriMode.ToString());




                    

                    // Add a mex endpoint




     //               long maxBufferPoolSize = binding.MaxBufferPoolSize;

      //              int maxBufferSize = binding.MaxBufferSize;
//
    //                int maxConnections = binding.MaxConnections;

     //               long maxReceivedMessageSize =
      //                  binding.MaxReceivedMessageSize;

       //             NetNamedPipeSecurity security = binding.Security;

      //              string scheme = binding.Scheme;



         //           BindingElementCollection bCollection = binding.CreateBindingElements();

       //             HostNameComparisonMode hostNameComparisonMode =
       //                 binding.HostNameComparisonMode;

       //             bool TransactionFlow = binding.TransactionFlow;

       //             TransactionProtocol transactionProtocol =
       //                 binding.TransactionProtocol;
//
          //          EnvelopeVersion envelopeVersion =
            //            binding.EnvelopeVersion;

             //       TransferMode transferMode = binding.TransferMode;




               //     Console.WriteLine("\nService endpoint {0} contains the following:", endpoint4.Name);
                //    Console.WriteLine("Binding: {0}", endpoint4.Binding.ToString());
              //      Console.WriteLine("Contract: {0}", endpoint4.Contract.ToString());
               //     Console.WriteLine("ListenUri: {0}", endpoint4.ListenUri.ToString());
              //      Console.WriteLine("ListenUriMode: {0}", endpoint4.ListenUriMode.ToString());

                    mojHost.Open();
                    Console.WriteLine("Serwis jest uruchomiony.");
                    Console.WriteLine("Nacisnij <ENTER> aby zakonczyc.");
                    Console.WriteLine();
                    Console.ReadLine();
                    mojHost.Close();

                    ContractDescription cd = ContractDescription.GetContract(typeof(ITablica));
                    Console.WriteLine("Displaying information for contract: {0}", cd.Name.ToString());

                    string configName = cd.ConfigurationName;
                    Console.WriteLine("\tConfiguration name: {0}", configName);
                    Type contractType = cd.ContractType;
                    Console.WriteLine("\tContract type: {0}", contractType.ToString());
                    bool hasProtectionLevel = cd.HasProtectionLevel;
                    if (hasProtectionLevel)
                    {
                        ProtectionLevel protectionLevel = cd.ProtectionLevel;
                        Console.WriteLine("\tProtection Level: {0}", protectionLevel.ToString());
                    }
                    string name = cd.Name;
                    Console.WriteLine("\tName: {0}", name);

                    string namespc = cd.Namespace;
                    Console.WriteLine("\tNamespace: {0}", namespc);

                    OperationDescriptionCollection odc = cd.Operations;
                    Console.WriteLine("\tDisplay Operations:");
                    foreach (OperationDescription od in odc)
                    {
                        Console.WriteLine("\t\t" + od.Name);
                    }
                    SessionMode sm = cd.SessionMode;
                    Console.WriteLine("\tSessionMode: {0}", sm.ToString());


                }
                catch (CommunicationException ce)
                {

                    Console.WriteLine("Wystapil wyjatek: {0}", ce.Message);
                    Console.ReadLine();
                    mojHost.Abort();
                }



            }
        }
    }

