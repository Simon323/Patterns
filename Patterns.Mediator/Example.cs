using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator
{
    public interface Mediator {
        void wyślij(String id, String wiadomość);
    }
 
class RzeczywistyMediator : Mediator {

    private Dictionary<String, Kolega> koledzy = new Dictionary<String, Kolega>();
 
    public void zarejestrujKolegę(Kolega k) {
        k.zarejestrujMediatora(this);
        koledzy.Add(k.getId(), k);
    }
 
    public void wyślij(String id, String wiadomość) {
        koledzy[id].odbierz(wiadomość);
    }
 }
 
class Kolega {

    private Mediator mediator;
    private String id;
 
    public Kolega(String id) { this.id = id; }
    public void zarejestrujMediatora(Mediator mediator) { this.mediator = mediator; }
    public String getId() { return id; }
 
    public void wyślij(String id, String wiadomość) {
        Console.WriteLine("Przesyłanie wiadomości od "+this.id+" do "+id+": "+wiadomość);
        mediator.wyślij(id, wiadomość); // Rzeczywista komunikacja odbywa się za pośrednictwem mediatora!!!
    }
 
    public void odbierz(String wiadomość) {
        Console.WriteLine("Wiadomość odebrana przez " + id + ": " + wiadomość); //zmiana 
    }
 }
 
class PrzykładoweUżycieMediatora {
    public static void Main(string[] args) {
        Kolega rene = new Kolega("rene");
        Kolega toni = new Kolega("toni");
        Kolega kim = new Kolega("kim");
 
        RzeczywistyMediator m = new RzeczywistyMediator();
        m.zarejestrujKolegę(rene);
        m.zarejestrujKolegę(toni);
        m.zarejestrujKolegę(kim);
 
        kim.wyślij("toni", "Hello world.");
        rene.wyślij("kim", "Witaj!");

    }
 }
}
