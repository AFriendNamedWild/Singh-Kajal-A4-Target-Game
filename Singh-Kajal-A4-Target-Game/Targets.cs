using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace MohawkGame2D
{
    public class Targets
    {
        float x = 0.0f;
        
        float y = 0.0f;



        public void SetUp()
        {

        }


        public void Update()
        {
            //Draw "Targets"

            Draw.FillColor = Color.Blue;


            for (int i = 0; i < 3; i++)
            {
                Vector2 position = new Vector2();

                float radius = 10f + (9 - 1) * 10;

                Draw.Square(position, radius);

                if (i % 2 == 0)
                {
                    Draw.FillColor = Color.Blue;
                }

                else
                {
                    Draw.FillColor = Color.White;
                }

            }
        }
    }
}
