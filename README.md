# HiveNet
### Идея для прототипирования.
Сервер для удаленного администрирования "роя" станков на предприятии.
Для реализации подключения между станками и "диспетчером" был взят TCP-протокол.
Хоть к месту был и менее ресурсозатратный UDP. TCP обеспечивает большую безопасность.

### Алгоритм работы:
"Диспетчер" включает сервер и слушает входящие соединения.
Клиент подключается к серверу и ждет от него команды для выполнения своих задач.
Для наглядности и у клиента и у "диспетчера" виден прогресс.
В случае сбоя сети на стороне клиента или сервера, обе стороны получают мгновенное уведомление.
  Хоть такая проверка и не предусмотренна TCP протоколом, сервер и клиент постоянно слушают транспортный поток в отдельном потоке
  и используют особенность TCP подключения: "при разрыве соединения в поток отправляется 0 байт". Это и является сигналом о разрыве. 

#### Теоритически-возможные уязвимости:
  0. Нет аутентификации подключившихся по протоколу TCP клиентов
  1. Открытый порт у диспетчера
  2. Атака (DDoS) по IP
  3. Backdoor "диспетчера".
  Для демонстрации нулевой уязвимости(под номером ноль), можно запустить любое другое приложение и подключиться по TCP протоколу.

#### Ver 1.0
##### Окно выбора.
![image](https://user-images.githubusercontent.com/37839328/114323063-e65b0580-9b3c-11eb-9130-0453670f0a67.png)
##### Окно сервера.
![image](https://user-images.githubusercontent.com/42736248/114350114-34462c80-9b82-11eb-9fe2-2076d3d07625.png)
##### Окно станка
![image](https://user-images.githubusercontent.com/37839328/114320780-0a184e80-9b31-11eb-8c0d-93d9a42235f6.png)
