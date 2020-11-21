# Примерен изпит

## Зад. 1 Цифра като дума
Напишете програма, която продължително приема едноцифрени числа за вход и ги принтира на конзолата като дума. 

| Вход | Изход |
|------|-------|
| 0    | Zero  |
| 1    | One   |
| 2    | Two   |
| 3    | Three |
| 4    | Four  |
| 5    | Five  |
| 6    | Six   |
| 7    | Seven |
| 8    | Eight |
| 9    | Nine  |
 
При въвеждане на **End** програмата да спира изпълнението си. За целта -  възползвайте се от библиотеката System.Exit и метода, който тя предлага exitWith, като го извикате с параметър ExitSuccess. При вход на отрицателно число или число с повече от 1 цифра да се изпише **Please only enter single digit positive numbers**. 

## Пример

| Вход | Изход                                           |
|------|-------------------------------------------------|
| 5    | Five                                            |
| 9    | Nine                                            |
| 11   | Please only enter single digit positive numbers |
| End  |                                                 |