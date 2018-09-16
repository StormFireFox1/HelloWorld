import java.util.Scanner;

/* "Reverse of a number"
 *
 * Ah, Java. The actual first *other* language I really learned.
 *
 * No programming language opened my horizons quite like Java did. I was a C nut before all the Java non-sense,
 * and it showed. Monolithical algorithms, no functions, no logical compartmentalization (at least outside of C#),
 * but with Java, everything changed. Java taught me the value of Object-Oriented Programming.
 *
 * Java was my first project language as well. I wrote an educational software, VianuEdu, in it, along with Go. It was a fun
 * experience, along with one of my classroom colleagues. It was a time when I finally decided to really get serious
 * when coding instead of screwing around with whatever I had in mind (which most commonly reduced itself to maths).
 *
 * Java also eased me into the GUI world with Swing. It still is pretty hard for me to code a GUI, but not as bad.
 *
 * This program reverses a number. Pretty self-explanatory.
 */
public class reverseNumber {

    public static void main(String[] args) {
        Scanner terminal = new Scanner(System.in);
        System.out.println("Hey, guy! Gimme a number: ");
        Integer number = terminal.nextInt();
        terminal.close();
        Integer reversedNumber = 0;
        while (number > 0) {
            reversedNumber = reversedNumber * 10 + (number % 10);
            number /= 10;
        }
        System.out.println("Reversed number: " + reversedNumber);
    }

}
