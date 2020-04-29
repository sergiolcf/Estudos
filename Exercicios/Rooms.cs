
namespace Exercicios {
    class Rooms {

        public int Quarto { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString() {
            return Name
                + ", E-mail.: "
                + Email
                + ", Quarto.: "
                + Quarto;
        }

    }


}
