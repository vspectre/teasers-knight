https://programmingpraxis.com/2012/01/20/knights-on-a-keypad/

Today’s exercise is an interview question that appeared on Stack Overflow a few years ago:

The numbers on a telephone keypad are arranged thus:

1 2 3
4 5 6
7 8 9
  0

Starting from the digit 1, and choosing successive digits as a knight moves in chess, determine how many different paths can be formed of length n. There is no need to make a list of the paths, only to count them.

A knight moves two steps either horizontally or vertically followed by one step in the perpendicular direction; thus, from the digit 1 on the keypad a knight can move to digits 6 or 8, and from the digit 4 on the keypad a knight can move to digits 3, 9 or 0. A path may visit the same digit more than once.

Your task is to write a function that determines the number of paths of length n that a knight can trace on a keyboard starting from digit 1.