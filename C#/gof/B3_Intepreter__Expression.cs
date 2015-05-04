//this code is rewritten from java version: http://www.oodesign.com/interpreter-pattern.html
//it's not typical use of Interpreter Pattern
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_Intepreter__Expression{
    public class Context {
        public Context(string input) {
            this.input = input;
        } 
        public string input {get; set;}
        public int output {get; set;}
	}

public abstract class Expression {

    public void interpret(Context context)
    {
      if (context.input.Length == 0) 
        return;

      if (context.input.StartsWith(nine())) {
        context.output = context.output + (9 * multiplier());
        context.input = context.input.Substring(2);
      } else if (context.input.StartsWith(four())) {
        context.output = context.output + (4 * multiplier());
        context.input = context.input.Substring(2);
      } else if (context.input.StartsWith(five())) {
        context.output = context.output + (5 * multiplier());
        context.input =  context.input.Substring(1);
      }

      while (context.input.StartsWith(one())) {
        context.output = context.output + (1 * multiplier());
        context.input = context.input.Substring(1);
      }
    }

    public abstract string one();
    public abstract string four();
    public abstract string five();
    public abstract string nine();
    public abstract int multiplier();
}

public class ThousandExpression : Expression{
    public override string one() { return "M"; }
    public override string four(){ return " "; }
    public override string five(){ return " "; }
    public override string nine(){ return " "; }
    public override int multiplier() { return 1000; }
}

public class HundredExpression : Expression{
    public  override string one() { return "C"; }
    public  override string four(){ return "CD"; }
    public  override string five(){ return "D"; }
    public  override string nine(){ return "CM"; }
    public  override int multiplier() { return 100; }
}

public class TenExpression : Expression{
    public override string one() { return "X"; }
    public override string four(){ return "XL"; }
    public override string five(){ return "L"; }
    public override string nine(){ return "XC"; }
    public override int multiplier() { return 10; }
}

public class OneExpression : Expression{
    public override string one() { return "I"; }
    public override string four(){ return "IV"; }
    public override string five(){ return "V"; }
    public override string nine(){ return "IX"; }
    public override int multiplier() { return 1; }
}

    public class MainInterpreter {
    	public static void Maini(string[] args) {
	        string roman = "MCMXXVIII";
	        Context context = new Context(roman);
	        // Build the 'parse tree' 
	        List<Expression> tree = new List<Expression>();
	        tree.Add(new ThousandExpression());
	        tree.Add(new HundredExpression());
	        tree.Add(new TenExpression());
	        tree.Add(new OneExpression());
	        // Interpret 
	        foreach (Expression exp in tree) {
	        	  exp.interpret(context);
	        }
	        Console.Out.WriteLine("{0} = {1}", roman, context.output);
            Console.In.Read(); 
	    }
    }
}
