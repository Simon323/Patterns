using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator
{
    public interface IMediator {
        void SendMoney(String id, int amount);
    }
 
class Kir : IMediator {

    private Dictionary<String, Bank> bankDictionary = new Dictionary<String, Bank>();

    public void AddBank(Bank k)
    {
        k.RegisterMediator(this);
        bankDictionary.Add(k.getId(), k);
    }

    public void SendMoney(String id, int amount)
    {
        bankDictionary[id].ReciveMoeny(amount);
    }
 }
 
class Bank {

    private IMediator mediator;
    private String id;

    public Bank(String id) { this.id = id; }
    public void RegisterMediator(IMediator mediator) { this.mediator = mediator; }
    public String getId() { return id; }

    public void SendMoney(String id, int amount)
    {
        Console.WriteLine("Przesyłanie pieniędzy od "+this.id+" do "+id+": "+ amount);
        mediator.SendMoney(id, amount); // Rzeczywista komunikacja odbywa się za pośrednictwem mediatora!!!
    }

    public void ReciveMoeny(int amount)
    {
        Console.WriteLine("Pieniądze odebranane przez " + id + ": " + amount);
    }
 }
 
class PrzykładoweUżycieMediatora {
    public static void Main(string[] args) {
        Bank rene = new Bank("rene");
        Bank toni = new Bank("toni");
        Bank kim = new Bank("kim");
 
        Kir m = new Kir();
        m.AddBank(rene);
        m.AddBank(toni);
        m.AddBank(kim);

        kim.SendMoney("toni", 3000);
        rene.SendMoney("kim", 1250);

        Console.ReadLine();
    }
 }
}
