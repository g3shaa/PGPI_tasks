<h1>Point & Rectangle</h1>
<h3>Примерна задача за матура</h3>
<hr>
<p><b>Нареждаме контролитевъв формата, както е показано на фигурата по-долу:</b></p>
<li>6 кутийки за въвеждане на число (NumericUpDown).</li>
<li>Надписи (Label) пред всяка кутийка за въвеждане на число.</li>
<li>Бутон (Button) за изчертаване на правоъгълника и точката.</li>
<li>Текстов блок за резултата (Label).</li>
<hr>
<p>Задаваме следните препоръчителни настройки на контролите:</p>
<p><b>За главната форма (Form), която съдържа всички контроли:</b></p>
<li>(name) = FormPointAndRectangle</li>
<li>Text = PointandRectangle</li>
<li>Font.Size = 12</li>
<li>Size = 700,410</li>
<li>MinimumSize = 500,400</li>
<li>FormBorderStyle = FixedSingle</li>
<p><b>За полетата за въвеждане на число (NumericUpDown):</b></p>
<li>(name) = numericUpDownX1; numericUpDownY1; numericUpDownX2; numericUpDownY2; numericUpDownX; numericUpDownY</li>
<li>Value = 2;-3;12;3;8;-1</li>
<li>Minimum = -100000</li>
<li>Maximum = 100000</li>
<li>DecimalPlaces = 2</li>
<p><b>За бутона (Button)за визуализация на правоъгълника и точката:</b></p>
<li>(name) = buttonDraw</li>
<li>Text = Draw</li>
<p><b>За текстовия блок за резултата (Label)::</b></p>
<li>(name) = labelLocation</li>
<li>AutoSize = false</li>
<li>BackColor = PaleGreen</li>
<li>TextAlign = MiddleCenter</li>
<p><b>За полето с чертежа (PictureBox):</b></p>
<li>(name) = pictureBox</li>
<li>Anchor = Top,Bottom,Left,Right</li>
<hr>
<p><b>Следва да хванем следните събития, за да напишем C# кода, който ще се изпълни при настъпването им:</b></p>
<li>Събитието Click на бутона buttonDraw (извиква се при натискане на бутона).</li>
<li>Събитието ValueChanged на контролите за въвеждане на числа numericUpDownX1, numericUpDownY1, numericUpDownX2, numericUpDownY2,numericUpDownX и numericUpDownY (извиква се при промяна на стойността в контролата за въвеждане на число).</li>
<li>Събитието Load на формата FormPointAndRectangle (извиква се при стартиране на приложението, преди да се появи главната форма на екрана).</li>
<li>Събитието Resize на формата FormPointAndRectangle (извиква се при промяна на размера на главната формата).</li>
<p><b>Всички изброени по-горе събития ще изпълняват едно и също действие –Draw(), което ще визуализира правоъгълника и точката и ще показва дали тя е вътре, вън или на някоя от страните.</b></p>
<hr>
<p>Накрая компилираме кода. Ако има грешки, ги отстраняваме. Най-вероятната причина за грешка е не съответстващо име на някоя от контролите или ако сте написали кода на неправилно място.</p>
<p>Стартираме приложението и го тестваме. Въвеждаме различни данни, за да видим дали се държи коректно.</p> 
