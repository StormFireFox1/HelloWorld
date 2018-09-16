#import <Foundation/Foundation.h>

/* "Swapping two variables"
 *
 * Ever had that one time when you thought "I want to write a mobile app!" This was me 4 years ago. Of course, I started with iOS,
 * or more accurately, Objective-C. I don't really like it, to be frank.
 *
 * It was too different from C and, at the time, I didn't have a Mac to code on or a virtualenv for Xcode to run in. So, in the end, I ended up
 * coding a simple little app from scratch. Needless to say, I didn't particularly like it, since there was no solid support for it at
 * the time. In the end, I kind of quit trying to do mobile for a while, eventually coming back to Android. "Must be easier, right?"
 * Eh, not by much.
 *
 * You see, back then, mobile apps required a butt-load of GUI support to easily code an UI for the mobile application. These days, it's
 * a lot better, but I still don't find myself coding GUI's too much. Thank God for Electron or Visual Studio when I *really* need a quick
 * UI.
 *
 * This algorithm simply swaps two integer variables by not using a third variable. It does this by storing the sum of two numbers in one
 * variable, then substracting in order to "swap" the variables.
 */

int main(int argc, const char * argv[]) {
    @autoreleasepool {      
        printf("Hey, guy! Gimme two numbers: ");
        int a, b;
        scanf("%i %i", a, b);
        a = a + b;
        b = a - b;
        a = a - b;
        printf("Done! Here are the two numbers: %i %i", a, b);
    }
    return 0;
}