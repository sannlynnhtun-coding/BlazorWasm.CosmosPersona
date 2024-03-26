namespace BlazorWasm.CosmosPersona.Models
{
    public class QuestionModel
    {
        public string Question { get; set; }
        public string Image { get; set; }
        public Answers Answers { get; set; }
    }

    public class Answers
    {
        public F F { get; set; }
        public T T { get; set; }
        public J J { get; set; }
        public P P { get; set; }
        public S S { get; set; }
        public N N { get; set; }
        public I I { get; set; }
        public E E { get; set; }
        public K K { get; set; }
        public U U { get; set; }
    }

    public class F
    {
        public string text { get; set; }
        public Scores scores { get; set; }
    }

    public class Scores
    {
        public int T { get; set; }
        public string F { get; set; }
    }

    public class T
    {
        public string text { get; set; }
        public Scores1 scores { get; set; }
    }

    public class Scores1
    {
        public string T { get; set; }
        public int F { get; set; }
    }

    public class J
    {
        public string text { get; set; }
        public Scores2 scores { get; set; }
    }

    public class Scores2
    {
        public int P { get; set; }
        public string J { get; set; }
    }

    public class P
    {
        public string text { get; set; }
        public Scores3 scores { get; set; }
    }

    public class Scores3
    {
        public string P { get; set; }
        public int J { get; set; }
    }

    public class S
    {
        public string text { get; set; }
        public Scores4 scores { get; set; }
    }

    public class Scores4
    {
        public string S { get; set; }
        public int N { get; set; }
    }

    public class N
    {
        public string text { get; set; }
        public Scores5 scores { get; set; }
    }

    public class Scores5
    {
        public int S { get; set; }
        public string N { get; set; }
    }

    public class I
    {
        public string text { get; set; }
        public Scores6 scores { get; set; }
    }

    public class Scores6
    {
        public object I { get; set; }
        public object E { get; set; }
    }

    public class E
    {
        public string text { get; set; }
        public Scores7 scores { get; set; }
    }

    public class Scores7
    {
        public object I { get; set; }
        public object E { get; set; }
    }

    public class K
    {
        public string text { get; set; }
    }

    public class U
    {
        public string text { get; set; }
    }
}
