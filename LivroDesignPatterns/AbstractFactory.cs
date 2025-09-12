// namespace FundamentosCsharp
// {

//   // Interfaces - produtos abstratos
//   public interface ICombustível
//   {
//     void TipoDeCombustivel();
//   }

//   public interface IMotor
//   {
//     void TipoDeMotor();
//   }

//   // Classes - produtos concretos

//   public class HiluxDiesel : ICombustível
//   {
//     public void TipoDeCombustivel()
//     {
//       Console.WriteLine("movido à Diesel");
//     }
//   }
//   public class HiluxGasolina : ICombustível
//   {
//     public void TipoDeCombustivel()
//     {
//       Console.WriteLine("movido à Gasolina");
//     }
//   }
//   public class HiluxFlex : ICombustível
//   {
//     public void TipoDeCombustivel()
//     {
//       Console.WriteLine("movido à Gasolina e Álcool.");
//     }
//   }

//   public class HiluxDoisPontoZero : IMotor
//   {
//     public void TipoDeMotor()
//     {
//       Console.WriteLine("Motor 2.0");
//     }
//   }
//   public class HiluxDoisPontoQuatro : IMotor
//   {
//     public void TipoDeMotor()
//     {
//       Console.WriteLine("Motor 2.4");
//     }
//   }
//   public class HiluxTresPontoZero : IMotor
//   {
//     public void TipoDeMotor()
//     {
//       Console.WriteLine("Motor 3.0");
//     }
//   }

//   // Interface - Comportamento da fábrica de Hilux
//   public interface IFabricaHilux
//   {
//     void CriarHilux();
//   }

//   // Implementação das Fábricas do tipo de Hilux

//   public class FabricaHiluxDoisPontoZeroDiesel : IFabricaHilux
//   {
//     public FabricaHiluxDoisPontoZeroDiesel()
//     {
//       CriarHilux();
//     }
//     public void CriarHilux()
//     {
//       Console.WriteLine("Hilux 2.0 Diesel escolhida");

//       HiluxDoisPontoZero motor = new HiluxDoisPontoZero();
//       HiluxDiesel combustivel = new HiluxDiesel();
//       motor.TipoDeMotor();
//       combustivel.TipoDeCombustivel();
//     }
//   }
//   public class FabricaHiluxTresPontoZeroFlex : IFabricaHilux
//   {
//     public FabricaHiluxTresPontoZeroFlex()
//     {
//       CriarHilux();
//     }
//     public void CriarHilux()
//     {
//       Console.WriteLine("Hilux 3.0 Flex escolhida");

//       HiluxTresPontoZero motor = new HiluxTresPontoZero();
//       HiluxFlex combustivel = new HiluxFlex();
//       motor.TipoDeMotor();
//       combustivel.TipoDeCombustivel();
//     }
//   }
//   public class FabricaHiluxDoisPontoQuatroGasolina : IFabricaHilux
//   {
//     public FabricaHiluxDoisPontoQuatroGasolina()
//     {
//       CriarHilux();
//     }
//     public void CriarHilux()
//     {
//       Console.WriteLine("Hilux 3.0 Flex escolhida");

//       HiluxDoisPontoQuatro motor = new HiluxDoisPontoQuatro();
//       HiluxGasolina combustivel = new HiluxGasolina();
//       motor.TipoDeMotor();
//       combustivel.TipoDeCombustivel();
//     }
//   }

//   class Program
//   {
//     static void Main(string[] args)
//     {
//       IFabricaHilux fabrica;
//       Console.WriteLine("Escolha um modelo de Hilux: 1 - 2.0 Diesel | 2 - 3.0 Flex | 3 - 2.4 Gasolina");

//       switch (Console.ReadLine())
//       {
//         case "1":
//           fabrica = new FabricaHiluxDoisPontoZeroDiesel();
//           break;
//         case "2":
//           fabrica = new FabricaHiluxTresPontoZeroFlex();
//           break;
//         case "3":
//           fabrica = new FabricaHiluxDoisPontoQuatroGasolina();
//           break;
//       }
//       Console.ReadLine();
//     }
//   }
// }