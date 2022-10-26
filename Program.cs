//---Variables---//
string a;
string b;
string c;
string d;
string e;
string f;
string g;
string h;
string i;
string j;
string k;
string l;
string m;
string n;
string o;
string p;
string q;
string r;
string s;
string playAgain = "Y";


//---loop---//
while (playAgain != "N")
{

    //---inputs, outputs, and storing---//

    Console.WriteLine("Hello there, we are going to do a Madlib!");

    Console.WriteLine("Please enter a male name.");
    a = Console.ReadLine();

    Console.WriteLine("Please enter the name of your favorite teacher.");
    b = Console.ReadLine();

    Console.WriteLine("Please enter an exclamation,for example: Oh gosh!");
    c = Console.ReadLine();

    Console.WriteLine("Please enter a number.");
    d = Console.ReadLine();

    Console.WriteLine("Please enter a plural object");
    e = Console.ReadLine();

    Console.WriteLine("Please enter a store name.");
    f = Console.ReadLine();

    Console.WriteLine("Please enter a body part.");
    g = Console.ReadLine();

    Console.WriteLine("Please enter an exclamation, for example: Oh gosh!");
    i = Console.ReadLine();

    Console.WriteLine("Please enter the name of a holiday.");
    j = Console.ReadLine();

    Console.WriteLine("Please enter the name of a movie title.");
    k = Console.ReadLine();

    Console.WriteLine("Please enter a verb ending in ing.");
    l = Console.ReadLine();

    Console.WriteLine("Please enter an amount of distance.");
    m = Console.ReadLine();

    Console.WriteLine("Please enter the name of a country.");
    n = Console.ReadLine();

    Console.WriteLine("Please enter the name of an animal.");
    o = Console.ReadLine();

    Console.WriteLine("Please enter your favorite quote.");
    p = Console.ReadLine();

    Console.WriteLine("Please enter the name of a body part.");
    q = Console.ReadLine();

    Console.WriteLine("Please enter the name of a children song.");
    r = Console.ReadLine();

    Console.WriteLine("Please enter an adjitive.");
    s = Console.ReadLine();


    //---Final Print---//

    Console.WriteLine($"Hello, I am detective {a}, and you are? My name is {b} replied {b}. You are here under suspicion of second degree roberry. {c}! shouted {b}. That's right {d} {e} were stolen from {f} and the crime scene has your {g} written all over it. That is {i}! shouted {b}. Where were you in the night of {j}? We were watching {k}, replied {b}. Then why does the security camera shows you {l} half {m} away from the crime scene? I'm done playing games! Where are you from? {n}, answered {b}. Just as I suspected. You know what? Best part of being a detective is that I get to lock up criminals like you and go home to my children and my pet {o} and say {p}. Fine! I did this, I committed the robery, but I only did it because I needed money to buy myself {q}, said {b}. I knew it all along! Every time I solve a crime I like to sing my favorite song {r}. You have a {s} voice, I love you! yelled {b}.");

    Console.WriteLine("Do you want to play again? Y/N");
    playAgain = Console.ReadLine().ToUpper();

}

Console.WriteLine("Bye!");