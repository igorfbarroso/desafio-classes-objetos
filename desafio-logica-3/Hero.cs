
namespace desafio_logica_3_
{
    public class Hero
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public string Type {get; set;}

      public Hero(string name, int age, string type)
      {
        Name = name;
        Age = age;
        Type = type;
      }

      public void Atacar ()
      {
        string attack = DescriptioOfAttack();
        Console.WriteLine($"O {Type} atacou usando {attack}");
        Console.WriteLine("===========================================");
      }

      private string DescriptioOfAttack()
      {
        if(Type is string type)
        {
            switch(Type.ToLower())
            {
                case "mago":
                return "magia";
                case "guerreiro":
                return "espada";
                case "monge":
                return "artes marciais";
                case "ninja":
                return "shuriken";
                default:
                return "ataque desconhecido";
            }
        }
        return "Tipo de herói inválido";
      }

    }
}