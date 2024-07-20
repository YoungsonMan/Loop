/**************************************************************************
 * 반복문 과제
 * 최연승
 * 과제 1. 입력받은 횟수만큼 반복하는 기능 제작
 * 과제 2. 다수의 입력을 받아 횟수만큼 반복하는 기능 제작
 * 과제 3. 구구단 기능 제작
 * 과제 4. 별찍기 기능 구현
 **************************************************************************/
namespace LoopAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***********************************************************************
             * 과제 1. 입력받은 횟수만큼 반복하는 기능
             * 사용자로부터 정수를 하나 입력받고, 그 수만큼 반복하는 문구 출력하기
            *************************************************************************/

            // "몇회 반복하시겠습니까? " 출력
            Console.WriteLine("몇회 반복하시겠습니까?");
            //// 입력을 받기
            string input = Console.ReadLine();
            // 인풋 저장 -> int로 변환
            int repeatNum;
            repeatNum = int.Parse(input);
            // "n회 반복중입니다"를 반복적으로 출력.
            for (int i = 1; i < repeatNum + 1; i++) // 0부터 인식해서 +1을 해서 그수만큼 되게끔.
            {
                Console.WriteLine($"{i}회 반복중입니다.");
            }
            Console.WriteLine("============================================================\n");

            /***************************************************************
             * 과제 2. 다수의 입력을 받아 횟수만큼 반복하는 기능 제작
             * 사용자로부터 정수 두개를 입력 받고 입력한 값을 포함
             * 그 사이에 있는 모든 정수의 합을 구하는 프로그램
             * EX. 4 와 7 입력 --> 4 + 5 + 6 + 7 의 결과 값인 22를 출력
             ****************************************************************/
            // "두 수 사이의 합을 구합니다. 시작 할 작은 수를 입력하여 주세요" 출력
            Console.WriteLine("두 수 사이의 합을 구합니다. 시작 할 작은 수를 입력하여 주세요");
            // 시작할 수 입력 받기
            string input01 = Console.ReadLine();
            int num1;
            num1 = int.Parse(input01);
            // "끝 수를 입력해 주세요" 출력
            Console.WriteLine("끝 수를 입력해 주세요");
            // 마지막 수 입력 받기
            string input02 = Console.ReadLine();
            int num2;
            num2 = int.Parse(input02);
            // 반복문을 통하여 시작부터 끝 수까지 합을 임의의 변수에 저장
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                Console.Write(i); // 숫자나오나 확인
                sum += i;
            }
            // 반복문이 끝난 후 "n1 과 n2 사이 숫자의 합은 n3 입니다" 출력
            Console.WriteLine(); //줄변경
            Console.WriteLine($"{num1} 과 {num2} 사이 숫자의 합은 {sum} 입니다");

            Console.WriteLine("============================================================\n");

            /******************************************************************************
             * 과제 3. 구구단
             * 유저로부터 정수 하나를 입력받고, 입력받은 수의 구구단을 출력하는 프로그램 제작.
             * Ex. 3 입력 -> 구구단 3단 출력
             * 유저가 입력한 수 > 9 || 숫자아닌것 입력하면 제대로된것 입력할때까지 반복
             **********************************************************************************/

            // "출력하고자 하는 구구단을 입력해주시길 바랍니다" 출력
            // 유저로부터 1-9까지의 숫자를 입력받음
            // 만약 1~9가 아닌 숫자 혹은 문자열이 들어오면 다시 입력하라고 반복시키기
            int answer;
            Console.WriteLine("출력하고자 하는 구구단(1~9)을 입력해주시길 바랍니다");
            do
            {
                string text = Console.ReadLine();
                bool success = int.TryParse(text, out answer);
                if (answer < 1 || 9 < answer)
                {
                    Console.WriteLine("1~9까지의 숫자를 입력하세요.");      // 다시해주세요 멘트
                }
            } while (answer < 1 || 9 < answer);     //  1~9 사이에 숫자를 넣을떄까지 반복.
                                                    // 구구단
            Console.WriteLine($"\n{answer}단을 시작합니다.");
            for (int i = 1; i <= 9; i++)
            {
                // "3 x 1 = 3, 3 x 2 = 6..." 등등 해당 구구단 출력
                Console.WriteLine($"{answer} * {i} = {answer * i}.");
            }


            /******************************************************************************
            * 과제 4. 별찍기 기능 구현
            * 중첩반복문을 활용하여 아래 그림처럼 출력하는 네가지 프로그램을 각각 작성하기.
            * Tip: Console.Write(" "); 빈공백, Console.WriteLine("*"); 별하나
            * *        *****          *    *****
            * **        ****         **     ****
            * ***        ***        ***      ***
            * ****        **       ****       **
            * *****        *      *****        *
            **********************************************************************************/

            // 1번
            Console.WriteLine("\n1번");
            for (int line = 1; line <= 5; line++)
            {
                for (int star = 1; star <= line; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // 2번
            Console.WriteLine("\n2번");
            for (int line = 1; line <= 5; line++)
            {
                // 빈칸부터 반복하여 찍기
                for (int star = 1; star <= 5 - line; star++)
                {
                    Console.Write(" ");
                }
                // 별찍기
                for (int star = 1; star <= line; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // 3번
            Console.WriteLine("\n3번");
            for (int line = 1; line <= 5; line++)
            {
                for (int star = 1; star <= 6 - line; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 4번
            Console.WriteLine("\n4번");
            for (int line = 1; line <= 5; line++)
            {
                //빈칸 찍기
                for (int star = 1; star <= line - 1; star++)
                {
                    Console.Write(" ");
                }
                // 별찍기
                for (int star = 1; star <= 6 - line; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



        }
    }
}
