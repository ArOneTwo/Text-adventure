using System.Linq;

Console.WriteLine("Selamat datang di text based adventure");
Console.WriteLine("Misi dari game ini adalah mengalahkan raja jahat yang ingin menguasai dunia");
Console.WriteLine("Gunakan kosakata bahasa inggris untuk melawannya\n");

Console.WriteLine("Silahkan pilih menu dibawah ini dengan angka");
Console.WriteLine("1.Mulai Permainan");
Console.WriteLine("2.Keluar permainan\n");

//Maksa input dari user
Console.WriteLine("Berikan input: ");
int opsi = Convert.ToInt32(Console.ReadLine());
if (opsi == 1){
    int skor = 100;
    Console.WriteLine("Permainan akan dimulai!");
    Console.WriteLine("Sebuah desa yang tidak disebutkan namanya mendapatkan sebuah peristiwa aneh, benda mati di seluruh kota berubah menjadi alfabet");
    Console.WriteLine("Anda, um..., siapakah anda ini? tolong tuliskan nama anda agar cerita ini dapat berlanjut");
    bool cekUsername = false;
    bool firstQuestion = false;
    string username;
    string testPertama;
    do{
        Console.WriteLine("Masukan user name anda: ");
        username = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(username) || username.Any(char.IsDigit)){
        Console.WriteLine("Saya tidak tahu nama anda jika anda menggunakan angka di dalam nama anda");
        } else {
        cekUsername = true;
        }
    } while (!cekUsername);
        Console.WriteLine("Selama permainan ini, saya akan memanggil anda " + username);
        Console.WriteLine("Selama permainan, anda memiliki skor sebanyak " + skor + " , jika anda dapat mempertahankan skor anda diatas 90 saya yakin anda adalah orang yang sangat memahami bahasa inggris");
        Console.WriteLine("Saya akan melanjutkan ceritanya\n");
        Console.WriteLine("Sebagai seorang penyihir yang memiliki literasi yang tinggi, dengan perasaan terheran-heran, anda mencoba untuk berpikir normal");
        Console.WriteLine("Meskipun anda sudah mencobanya berkali-kali, peristiwa aneh ini adalah nyata.");
        Console.WriteLine("Terdapat tantangan pertama di depan anda, bangunan tersebut ");
        Console.WriteLine("Di depan, ada sebuah papan yang bertuliskan");
        Console.WriteLine("'Aku adalah bangunan yang digunakan untuk mengambil air di dalam tanah, bangunan apakah aku?'");
        Console.WriteLine(username + " mencoba menggunakan bahasa indonesia yaitu sumur, tetapi papan tersebut masih ada, mungkin anda dapat menggunakan bahasa inggris untuk menyelesaikannya\n");
        //First Question
        while(!firstQuestion){
            Console.WriteLine("Pilih jawaban yang menurut anda benar!");
            Console.WriteLine("1.Well");
            Console.WriteLine("2.Boar");
            Console.WriteLine("3.Bite");
            int answer1 = int.Parse(Console.ReadLine());
            if (answer1 == 1){
                Console.WriteLine("Tepat, jawaban anda benar!");
                firstQuestion = true;
            } else {
                skor -= 2;
                Console.WriteLine("Jawaban anda salah, tolong ingat-ingat kembali");
                if (skor == 0){
                    Console.WriteLine("Anda kalah, silahkan ulangi dari awal lagi");
                    break;
                };
            }
            Console.WriteLine("Skor anda saat ini adalah " + skor);
            Console.WriteLine("Sumur yang tadinya hanya berisi kata-kata tersebut kemudian berubah wujud menjadi sumur pada umumnya, setelah itu, anda mulai menyelesaikan beberapa teka-teki ini berbagai tempat di desa");
            Console.WriteLine("Tiba-tiba ada sebuah tantangan yang mengharuskan untuk menulis kalimat dalam bahasa inggris, isi tulisan tersebuut berisi");
            Console.WriteLine("Mr.Postman ")
        }
} else if (opsi == 2){
    Console.WriteLine("Mengakhiri permainan...");
}