Функции на потребители (без вход):

1.	Да мога да разгледам какви полети има.
2.	Да мога да изпращам заявка за резервация на даден полет.
3.	Да мога да избера дали искам Бизнес/Икономическа класа.
4.	Да мога да въведа броя на хора за съответния полет.
5.	Да въведа данните си + E-mail
6.	*Да въведа данните за останалите (ако има)
7.	Да ми бъде пратен имейл за потвърждение, че съм резервирал полета успешно



Функции на единия единствен администратор:

1.	Да мога да се log-in-на / Log-out-на
2.	Да мога да създавам и променям данни за полети.
3.	Да виждам различните потребители и резервациите им
4.	Да мога да филтрирам/търся по определени показатели (имейл; потребителски; собствено име; фамилно име)
5.	Странициране (Да си избира по колко потребителя вижда на страница. 10; 25; 50)



Функции на неадминистративните потребители (служители):
1.	Log-in / Log-out
2.	Да мога да разглеждам данни за резервации и полети
3.	Да мога да филтрирам/търся по определени показатели (имейл; потребителски; собствено име; фамилно име)
4.	Странициране (Да си избира по колко потребителя вижда на страница. 10; 25; 50)





Служители:

Id
Username
Password
Email
First name
Last name
EGN
Address
Phone Number
Role?


Полети:
ID
From
To
Take off time and date
Landing Time and Date
Plane model
Plane ID
Pilot Name
Capacity Eco
Capacity Business





Резервации:
ID
Flight-ID
Email
Бройка


Отделните хора:
ID
Reservation-ID
First Name
Second Name
Last Name
EGN
Phone Number
Nationality
Business or Eco





Бази данни:
UI:
Документация:
NUnit Tests:
