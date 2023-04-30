namespace Csharp
{
    public class OOP
    {
        //Polymorphism
        abstract class Interface1   {public abstract bool movement();} //abstract class
        class useOfInterface2 : Interface1  { public override bool movement() { return true; } }
        public interface Interface2 {bool movement1();}//interface
        class useOfinterface : Interface2  {public bool movement1() { return false; }}
        class Inheritance        {public virtual string move() { return "hi"; } }//inheritance
        class devired: Inheritance   {public override string move() { return "wtf"; }}

//Relationship 
        class Associate { public void function1() {Associate2 obj;} }
        class Associate2 { public void function2(Associate obj) {} }
////////////////////////////////////////////////////////
        class Aggregation {  //weak bond //has-a relationship
            public devired aggreg;
            public Aggregation(devired aggreg1) { aggreg = aggreg1; }
        }
//Body </>--- Heart //if heart destroy, body may destroy
//if body destroy, heart must destroy
        class Body {heart ht = new heart();} //part-of relationship
        class heart { }

//aggregation  //ICTdept <>-- Teacher //if teacher left, ICT dept still here
//ICT dept destroyed, teacher still here??
        public class IDGBlogAccount {private IDGBlogEntry[] blogEntries;}
        public class IDGBlogEntry   {    string text;}
    }
}