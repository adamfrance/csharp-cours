## 3.1

Que se passe-t-il lorsque vous divisez un intvariable par 0?
Que se passe-t-il lorsque vous divisez un doublevariable par 0?
Que se passe-t-il lorsque vous débordez d'un intvariable, c'est-à-dire la définir sur une valeur au-delà de sa plage ?
Quelle est la différence entre x = y++; et x = ++y;?
Quelle est la différence entre break, continue, et return lorsqu'il est utilisé dans une instruction de boucle ?
Quelles sont les trois parties d'une déclaration for et lesquelles sont requises ?
Quelle est la différence entre les opérateurs = et ==?

## 3.2

Que se passera-t-il si ce code s'exécute ?

int max = 500;
for (byte i = 0; i < max; i++)
{
  WriteLine(i);
}

## 3.3

Quelles seront les valeurs de x et y ?

x = 3;
y = 2 + ++x;

x = 3 << 2;
y = 10 >> 1;

x = 10 & 8;
y = 10 | 7;

## 3.4

FizzBuzz est un jeu collectif destiné aux enfants pour leur apprendre la division. Les joueurs comptent à tour de rôle progressivement, en remplaçant tout nombre divisible par 3 par le mot fizz , tout nombre divisible par 5 par le mot buzz et tout nombre divisible par les deux par fizzbuzz . 

## 3.5 

Créez une application console dans Partie 3 qui demande à l'utilisateur deux nombres compris entre 0 et 255, puis divise le premier nombre par le second :

Enter a number between 0 and 255: 100
Enter another number between 0 and 255: 8
100 divided by 8 is 12

Écrivez des gestionnaires d'exceptions pour détecter toutes les erreurs générées, comme indiqué dans le résultat suivant :

Enter a number between 0 and 255: apples
Enter another number between 0 and 255: bananas 
FormatException: Input string was not in a correct format.


