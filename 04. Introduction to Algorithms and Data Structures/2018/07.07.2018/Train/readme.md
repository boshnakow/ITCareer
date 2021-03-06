﻿# Влак
Вие управлявате една малка жп гара. Въпреки че гарата е много малка от нея тръгват влакове - както пътнически, така и товарни. 
Един от коловозите на гарата е зает с вагони за композициите. По другия може да се минава, за да се напусне гарата или пък, за да мине машина, 
която иска да вземе вагони от другия коловоз.

Вашата задача е по дадена информация за всеки влак да създадете разписание, което спазва правилата за приоритет за преминаване през свободния коловоз.

Приемете, че преминаването по коловоза отнема винаги еднакво време и се случва винаги с еднаква скорост, 
а след като влакът е преминал по него той вече не може да предизвика конфликт с друг влак.

Приоритетът на преминаване е следният. Винаги разглеждаме последните два добавени влака. От тях влакът се определя по следния приоритет:
- Товарни влакове с повече от 15 вагона
- Пътнически влакове
- Товарни влакове с по-малко от 15 вагона

Ако само един влак е в списък на чакащите, то минава той без значение какъв е.

## Пример 1
Вход
```
Add 85611 Karlovo P 2
Add 82223 Sofia P 3
Add 12123 Varna P 4
Next
Travel
Next
Add 12125 Plovdiv P 4
Add 12126 Karnobat P 4
Travel
Next
Travel
Add 12127 Karnobat P 2
End
```
Изход
```
12123 Varna P 4
12123 Varna P 4
82223 Sofia P 3
12126 Karnobat P 4
12125 Plovdiv P 4
12125 Plovdiv P 4
```
В този пример варненският влак напуска гарата, но след напускането му добавяме два влака – пловдивски и карнобатски, 
като има точно 2 команди Travel – те придвижват карнобатския и пловдивския влак. 
След това добавяме и още един карнобатски влак, но понеже преди End командата не извикваме Travel отново – тези влакове не се появяват в изхода.

## Пример 2
Вход
```
Add 85611 Karlovo P 2
Add 82223 Sofia P 3
Add 12123 Varna P 4
Next
Travel
Next
Add 12125 Plovdiv P 4
Add 12126 Karnobat P 4
Travel
History
Next
Travel
History
End
```
Изход
```
12123 Varna P 4
12123 Varna P 4
82223 Sofia P 3
12126 Karnobat P 4
12126 Karnobat P 4
12123 Varna P 4
12125 Plovdiv P 4
12125 Plovdiv P 4
12125 Plovdiv P 4
12126 Karnobat P 4
12123 Varna P 4
```
В този пример първо заминава варненския влак, после добавяме пловдивски и карнобатски, след което карнобатския заминава. 
При справката за история изкарваме карнобатския и варненския влак. След това продължаваме с преминаване на пловдивския влак. 
Отново изакрваме справка, в която фигурират пловдивския, карнобатския и варненския влак – според реда на преминаваме (от най-скорошен към най-отдавнашен).

## Пример 3
Вход
```
Add 31233 BobovDol F 30
Add 85611 Karlovo P 3
Add 22222 Tulovo F 10
Travel
Travel
Travel
Add 31234 BobovDol F 30
Add 85612 Karlovo P 3
Travel
History
End
```
Изход
```
85611 Karlovo P 3
22222 Tulovo F 10
31233 BobovDol F 30
31234 BobovDol F 30
31234 BobovDol F 30
31233 BobovDol F 30
22222 Tulovo F 10
85611 Karlovo P 3
```
В този случай първо добавяме 3 влака – товарен за Бобов Дол, пътнически за Карлово и един товарен за Тулово с 10 вагона. 
Понеже сравняваме само последните 2 влака – пътническият е с приоритет пред товарния, т.като той е с по-малко от 10 вагона – затова карловския минава пръв. 
След това остават само двата товарни, следователно минава туловския и едва след това този за Бобов Дол.

След това добавяме два влака – товарен за Бобов Дол с 30 вагона, а след него пътнически с 3 вагона – 
понеже дългите товарни влакове са с приоритет над пътническите – влакът за Бобов Дол минава. 
В историческата справка излизат двата влака за Бобов Дол, влакът за Тулово и първият влак за Карлово.