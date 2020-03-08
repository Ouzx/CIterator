# CIterator
ClassIteration

http://www.idlebundle.com/c-functional-class-iteration-generic/
[TR]
C# dilinde binary-writing diye bir olay var.
Verilerinizi kısmen-binary olarak tutup saklamanıza ve kaydetmenize olanak sağlıyor.
Ve gayet de hızlı çalışıyor. Ancak binary-writer olayının bazı sıkıntıları var.
Bu sıkıntılardan en büyüğü bir sınıfı bw’a parametre olarak verip kaydedemiyorsunuz.
Tüm propertyleri tek tek vermeniz gerekli.
Bunun üzerinde biraz araştırma yaptıktan sonra bw için çok kullanışlı olduğunu düşündüğüm bu scripti yazdım.
CIterator sınıfını ilgili bw metoduna dahil ettiğinizde tek seferde bir sınıfı okumuş ve yazmış olursunuz.
[ENG]
There is a sitution called binary write in C #.
It allows you to store your data partially in binary format.
And it works very fast. However, the binary-writer has some problems.
You can not store a class as binary format with binary-writer.
You have to save all properties of the class individually using binary-writer.
After doing some research on this, I wrote this tool, which I think is very useful for bw.
When you include the CIterator class in the relevant binary-writer method, you can read and write one class at a time.
