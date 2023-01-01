using System.Linq;
using System;
using Timers = System.Timers;
using System.Threading;

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
    int robot = 15;
    Console.WriteLine("Permainan akan dimulai!");
    Console.WriteLine("Sebuah desa yang tidak disebutkan namanya mendapatkan sebuah peristiwa aneh, benda mati di seluruh kota berubah menjadi alfabet");
    Console.WriteLine("Anda, um..., siapakah anda ini? tolong tuliskan nama anda agar cerita ini dapat berlanjut");
    bool cekUsername = false;
    bool firstQuestion = false;
    bool secondQuestion = false;
    bool thirdQuestion = false;
    bool fourthQuestion = false;
    bool finalQuestion1 = false;
    bool finalQuestion2 = false;
    string username;
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
        Console.ReadLine();
        Console.WriteLine("Selama permainan, anda memiliki skor sebanyak " + skor + " , jika anda dapat mempertahankan skor anda diatas 80 saya yakin anda adalah orang yang sangat memahami bahasa inggris");
        Console.ReadLine();
        Console.WriteLine("Saya akan melanjutkan ceritanya\n");
        Console.ReadLine();
        Console.WriteLine("Sebagai seorang penyihir yang memiliki literasi yang tinggi, dengan perasaan terheran-heran, anda mencoba untuk berpikir normal");
        Console.ReadLine();
        Console.WriteLine("Meskipun anda sudah mencobanya berkali-kali, peristiwa aneh ini adalah nyata.");
        Console.ReadLine();
        Console.WriteLine("Terdapat tantangan pertama di depan anda, bangunan tersebut ");
        Console.ReadLine();
        Console.WriteLine("Di depan, ada sebuah papan yang bertuliskan");
        Console.ReadLine();
        Console.WriteLine("'Aku adalah bangunan yang digunakan untuk mengambil air di dalam tanah, bangunan apakah aku?'");
        Console.ReadLine();
        Console.WriteLine(username + " mencoba menggunakan bahasa indonesia yaitu sumur, tetapi papan tersebut masih ada, mungkin anda dapat menggunakan bahasa inggris untuk menyelesaikannya\n");
        Console.ReadLine();
        //First Question
        while(!firstQuestion){
            Console.WriteLine("Pilih jawaban yang menurut anda benar!");
            Console.WriteLine("1.Well");
            Console.WriteLine("2.Boar");
            Console.WriteLine("3.Bite");
            int answer1 = int.Parse(Console.ReadLine());
            if (answer1 == 1){
                Console.WriteLine("Tepat, jawaban anda benar!\n");
                firstQuestion = true;
            } else {
                skor -= 2;
                Console.WriteLine("Jawaban anda salah, tolong ingat-ingat kembali");
                if (skor == 0){
                    Console.WriteLine("Anda kalah, silahkan ulangi dari awal lagi");
                    break;
                };
            }
        }
        Console.WriteLine("Skor anda saat ini adalah " + skor);
        Console.ReadLine();
        Console.WriteLine("Sumur yang tadinya hanya berisi kata-kata tersebut kemudian berubah wujud menjadi sumur pada umumnya, setelah itu, anda mulai menyelesaikan beberapa teka-teki ini berbagai tempat di desa");
        Console.ReadLine();
        Console.WriteLine("Tiba-tiba ada sebuah tantangan yang mengharuskan untuk menulis kalimat dalam bahasa inggris, isi tulisan tersebut berisi");
        Console.ReadLine();
        Console.WriteLine("Please send this to [PLACE THAT USED FOR BUYING AND SELLING ITEMS]");
        Console.ReadLine();
        Console.WriteLine("Kira-kira tempat apakah yang dimaksud di dalam pesan ini??");
            while(!secondQuestion){
                        Console.WriteLine("Berikan jawaban yang tepat untuk pertanyaan diatas:");
                        string ketik1 = Console.ReadLine();
                        if(ketik1.ToLower().Trim() == "shop"){
                            Console.WriteLine("Jawaban anda benar, nama tempat dalam bahasa inggris itu terisi dengan shop\n");
                            secondQuestion = true;
                            } else if (ketik1.ToLower().Trim() == "toko"){
                            skor -= 1;
                            Console.WriteLine("Tolong gunakan bahasa inggris");
                            } else {
                                skor -=2;
                                Console.WriteLine("Jawaban salah");
                            if (skor == 0){
                            Console.WriteLine("Anda kalah, silahkan ulangi dari awal lagi");
                            break;
                    };
                }
            }
            Console.WriteLine("Skor anda saat ini adalah " + skor);
            Console.ReadLine();
            Console.WriteLine("Pesan tersebut berisi barang-barang yang akan di berikan ke toko terdekat, anda dengan segera mengantarkan barang tersebut");
            Console.ReadLine();
            Console.WriteLine("Setelah barang tersebut diantarkan, anda mencoba menghubungi kota tetangga untuk meminta bantuan atas terjadinya insiden ini");
            Console.ReadLine();
            Console.WriteLine("Sayangnya, energi yang memungkinkan untuk berkomunikasi untuk kota tetangga saat ini terputus dikarenakan insiden ini, sepertinya ini sejenis penghalang");
            Console.ReadLine();
            Console.WriteLine("Mau tidak mau, anda harus pergi menyusuri tempat-tempat berbahaya di sekitar desa anda untuk dapat mencari bantuan ke kota tetangga\n\n");
            Console.ReadLine();
            Console.WriteLine("Tantangan ketiga muncul tepat setelah anda meninggalkan desa, anda dihadang oleh sekumpulan bandit, tetapi sepertinya niat mereka tidak jahat");
            Console.ReadLine();
            Console.WriteLine("Bandit-bandit tersebut memiliki kesusahan untuk menguasai bahasa inggris, mereka tidak bisa kemana-mana karena ternyata insiden aneh di desa ini sudah menyebar ke luar desa");
            Console.ReadLine();
            Console.WriteLine("Mereka meminta tolong kepada anda untuk mengajarkan anda bahasa inggris, anda kemudian menolak dengan halus, tetapi salah satu anggotanya kesal dengan anda karena anda dianggap sombong");
            Console.ReadLine();
            Console.WriteLine("Salah satunya mencoba menenangkannya, anda memberikan kepada mereka sebuah kamus sebagai senjata andalan untuk menghadapi insiden aneh ini");
            Console.ReadLine();
            Console.WriteLine("Pada awalnya sekelompok bandit ini tidak percaya, jadi mereka menyuruh anda untuk mengubah pohon yang menjadi kumpulan alfabet menjadi pohon pada umumnya\n");
                while(!thirdQuestion){
                        Console.WriteLine("Terjemahkan objek tersebut ke bahasa inggris");
                        string ketik2 = Console.ReadLine();
                        if(ketik2.ToLower().Trim() == "tree"){
                            skor += 3;
                            Console.WriteLine("Jawaban anda benar, alfabet tersebut bertransformasi menjadi pohon pada umumnya\n");
                            thirdQuestion = true;
                        } else if (ketik2.ToLower().Trim() == "pohon"){
                            skor -= 1;
                            Console.WriteLine("Tidak terjadi apa, lebih baik gunakan bahasa inggris");
                        } else {
                            skor -= 2;
                            Console.WriteLine("Para bandit itu mulai meragukan kemampuan bahasa inggris anda, mereka mulai menggangap anda adalah seseorang yang pelit ilmu");
                            if (skor == 0){
                            Console.WriteLine("Para bandit tersebut sudah muak dengan jawaban yang anda berikan tidak mengubah bentuk pohon itu sama sekali");
                            Console.WriteLine("Pada akhirnya anda mau tidak mau harus mengajar mereka setiap hari, sehingga anda tidak bisa menemukan bantuan dari kota sebelah");
                            Console.WriteLine("Anda telah kalah");
                            break;
                    }
                }
            }
            Console.WriteLine("Setelah mempercayai anda, mereka akhirnya dengan sukarela membolehkan anda untuk pergi. Mereka berjanji akan menggunakan kamus itu sebaik mungkin");
            Console.ReadLine();
            Console.WriteLine("Di tengah perjalanan, ada sebuah kereta kuda yang mengalami kecelakaan, untungnya tidak ada siapapun di dalam");
            Console.ReadLine();
            Console.WriteLine("Tiba-tiba, anda melihat sebuah catatan di pinggir kereta kuda tersebut");
            Console.ReadLine();
            Console.WriteLine("Catatan itu berisi langkah-langkah untuk mendapatkan uang dengan cara yang tidak masuk akal");
            Console.ReadLine();
            Console.WriteLine("1.Luncurkan sebuah virus yang mengubah seluruh benda mati menjadi alfabet");
            Console.ReadLine();
            Console.WriteLine("2.Buka jasa layanan bahasa asing");
            Console.ReadLine();
            Console.WriteLine("3.Pasang harga yang mahal");
            Console.ReadLine();
            Console.WriteLine("4.Untung sebanyak-banyaknya");
            Console.ReadLine();
            Console.WriteLine("Titik temunya ada di kota haphazard");
            Console.ReadLine();
            Console.WriteLine("'Ini kan, kota megah yang berjarak tidak jauh dari desaku' celetuk anda");
            Console.ReadLine();
            Console.WriteLine("ternyata catatan tersebut masih belum selesai");
            Console.ReadLine();
            Console.WriteLine("Kode peluncuran kedua dengan target seluruh dunia adalah 5234");
            Console.ReadLine();
            Console.WriteLine("Kemudian anda melihat dokumen mengenai rancangan alat yang menyebabkan bencana tersebut");
            Console.ReadLine();
            Console.WriteLine("'Mereka adalah dalang yang menyebabkan insiden aneh ini, aku harus menghentikannya' ucap anda di dalam hati");
            Console.ReadLine();
            Console.WriteLine("Dengan cepat, anda bergegas ke kota sebelah menggunakan rute tercepat untuk mencapai kota tersebut\n\n");
            Console.ReadLine();
            //Tiba di kota
            Console.WriteLine("Setelah perjalanan nyaris 2 hari penuh, anda sampai di kota tersebut dengan kota yang sudah hancur");
            Console.ReadLine();
            Console.WriteLine("Banyak orang yang mengungsi di pinggiran kota dikarenakan hampir semua barang tidak dapat digunakan");
            Console.ReadLine();
            Console.WriteLine("Sejauh mata memandang, hanya ada lautan alfabet dan bangunan yang tersisa setengah dari insiden aneh ini");
            Console.ReadLine();
            Console.WriteLine("Tidak lama, ada orang asing yang menarik anda ke sebuah gubuk, orang itu tahu bahwa anda adalah orang yang bisa menghilangkan alfabet yang menyelimuti desa");
            Console.ReadLine();
            Console.WriteLine("Mereka meminta anda untuk menemani mereka ke pusat penelitian dimana alat itu disimpan");
            Console.ReadLine();
            Console.WriteLine("'Kami memiliki informasi untuk mencari lokasi tempat dimana mereka mengembangkan alat yang mengubah benda mati menjadi alfabet'");
            Console.ReadLine();
            Console.WriteLine("Anda merasa ragu dengan mereka, jadi anda meminta mereka untuk menunjukan bukti bahwa mereka memang tahu dan seluk beluk lokasinya");
            Console.ReadLine();
            Console.WriteLine("Salah satu dari mereka bernama Ante, menunjukan rancangan prototipe awal yang sudah mendapatkan tanda tangan resmi dari pemilik lab tersebut");
            Console.ReadLine();
            Console.WriteLine("Kemudian salah satunya lagi menunjukan rekaman percakapan untuk peluncuran alat tersebut");
            Console.ReadLine();
            Console.WriteLine("Pada akhirnya, anda mau tidak mau harus mengikuti mereka\n\n");
            Console.ReadLine();
            Console.WriteLine("Tidak butuh waktu 2 hari, ante dan para anggotanya lainnya sudah paham dasar");
            Console.ReadLine();
            Console.WriteLine("Ante dan teman-temannya langsung mengajak anda ke suatu tempat yang hanya sebagian orang yang tahu");
            Console.ReadLine();
            //Tunnel
            Console.WriteLine("Setelah sampai ke bawah tanah, anda dan lainnya berjalan menyusuri lorong tersebut");
            Console.ReadLine();
            Console.WriteLine("Karena terburu-buru, ada salah satu anggota ante yang jatuh ke jurang tak berdasar di depan");
            Console.ReadLine();
            Console.WriteLine("Jalur itu ternyata terbagi dua, yang pertama mengarah ke restoran terbengkalai dan yang kedua mengarah ke taman kota");
            Console.ReadLine();
            Console.WriteLine("Jadi anda memastikan si ante lebih baik lewat restoran terbengkalai atau lewat taman kota\n");
                while(!fourthQuestion){
                    Console.WriteLine("Silahkan pilih kalimat mana yang ingin anda terjemahkan");
                    string ketik3 = Console.ReadLine();
                    if(ketik3.ToLower().Trim() == "park"){
                        Console.WriteLine("Anda dan lainnya menuju ke taman kota");
                        Console.ReadLine();
                        Console.WriteLine("Ternyata tangga untuk naik ke atas sudah rusak");
                        Console.ReadLine();
                        Console.WriteLine("Kembali ke titik awal");
                        Console.ReadLine();
                        skor -= 1;
                    } else if (ketik3.ToLower().Trim() == "restaurant"){
                        skor += 2;
                        Console.WriteLine("Anda dan lainnya pergi menuju restoran yang terbengkalai");
                        Console.ReadLine();
                        Console.WriteLine("Beruntung tangga keatas masih bisa dipakai");
                        Console.ReadLine();
                        Console.WriteLine("Setelah semuanya naik, dengan cepat anda bergegas ke pusat penelitian\n");
                        Console.ReadLine();
                        fourthQuestion = true;
                    }
                }
                Console.WriteLine("Skor anda saat ini adalah " + skor);
                Console.ReadLine();
                Console.WriteLine("Sesampainya di pusat penelitian, ada banyak sekali robot yang menjaga pintu masuk tersebut");
                Console.ReadLine();
                Console.WriteLine("Untunglah robot-robot tersebut sedang dalam kondisi tidak aktif");
                Console.ReadLine();
                Console.WriteLine("Setelah sampai ke dalam, pelaku ternyata sudah kabur dari lab penelitian tersebut");
                Console.ReadLine();
                Console.WriteLine("Alat tersebut ternyata ada di dalam sebuah tabung");
                Console.ReadLine();
                Console.WriteLine("Sisa beberapa langkah lagi, sebuah robot tiba-tiba muncul dan menyerang siapapun yang mencoba mendekati alat itu, sepertinya pelaku sudah menyalakan sistem keamanan otomatis lebih dahulu");
                Console.ReadLine();
                Console.WriteLine("Gunakan seluruh kemampuan anda untuk mengalahkan robot itu\n");
                while(!finalQuestion1){
                    Console.WriteLine("Robot tersebut memulai serangan pertamanya");
                    Console.ReadLine();
                    Console.WriteLine("Robot tersebut melompat keatas, muncul sebuah papan di layar dekat pintu masuk");
                    Console.ReadLine();
                    Console.WriteLine("'Alat yang digunakan untuk menulis dan tulisan tersebut tidak dapat dihapus dengan penghapus adalah...\n'");
                    string jawaban4 = Console.ReadLine();
                    if(jawaban4.ToLower().Trim() == "pen"){
                        robot -= 10;
                        Console.WriteLine("Puluhan benda yang menyerupai pulpen muncul di depan");
                        Console.ReadLine();
                        Console.WriteLine("Pulpen tersebut langsung mengarah ke robot tersebut dan menimbulkan luka yang tidak terlalu besar");
                        Console.ReadLine();
                        Console.WriteLine("HP robot berkurang 5\n");
                        finalQuestion1 = true;
                    } else {
                        skor -= 10;
                        Console.WriteLine("Robot tersebut mendarat dan menghasilkan hentakan keras, hentakan itu menghempas tim anda");
                        Console.WriteLine("HP anda berkurang 10\n");
                    }
                } 
                    Console.WriteLine("Setelah terkena serangan tersebut, robot itu masih bisa bergerak dan mulai melancarkan serangan berikutnya");
                    Console.WriteLine("Robot tersebut mulai menembakan sebuah laser!");
                    while(!finalQuestion2){
                        Console.WriteLine("Robot tersebut memulai serangan keduanya");
                        Console.ReadLine();
                        Console.WriteLine("Tulisan aneh kemudian muncul lagi di hadapanmu");
                        Console.ReadLine();
                        Console.WriteLine("'Alat yang digunakan untuk membuka gembok adalah...'\n");
                        string jawaban5 = Console.ReadLine();
                        if(jawaban5.ToLower().Trim() == "key"){
                            robot -= 10;
                            Console.WriteLine("Kunci kemudian muncul di hadapanmu, tetapi robot tersebut sudah melancarkan serangan lasernya");
                            Console.ReadLine();    
                            Console.WriteLine("Dengan cepat, kunci tersebut anda serahkan ke ante yang kebetulan ada di belakang robot");
                            Console.ReadLine();
                            Console.WriteLine("Tak butuh waktu lama, ante menemukan sebuah lubang menyerupai kunci, dia memasukan kunci ke lubang itu dan");
                            Console.ReadLine();
                            Console.WriteLine("Robot tersebut kemudian masuk ke dalam mode hibernasi");
                            Console.ReadLine();
                            Console.WriteLine("Anda dengan cepat mendekati mesin yang masih tersegel tersebut dan menghancurkannya");
                            Console.ReadLine();
                            Console.WriteLine("Setelah mesin itu hancur, media televisi mengatakan bahwa alfabet-alfabet aneh itu sudah menghilang");
                            Console.ReadLine();
                            Console.WriteLine("Dan sekarang alfabet-alfabet itu kembali menjadi objek asli seutuhnya");
                            Console.ReadLine();
                            Console.WriteLine("Akhirnya, bencana dan insiden aneh ini berakhir juga!");
                            Console.ReadLine();
                            Console.WriteLine("ANDA MENANG!\n");
                            finalQuestion2 = true;
                        } else {
                            skor -= 75;
                            Console.WriteLine("Robot itu menembakan laser dalam jangkauan luas yang menghancurkan gedung tersebut");
                            Console.ReadLine();
                            Console.WriteLine("Alat yang membuat alfabet itu masih bergerak dan meluncurkan serangan keduanya");
                            Console.ReadLine();
                            Console.WriteLine("Sekarang seluruh dunia sudah terkena efek yang serupa dengan desa yang anda tinggali");
                            Console.ReadLine();
                            Console.WriteLine("Anda terlambat untuk menerjemahkan kata floor sehingga anda dan kelompok lain terjatuh ke dalam jurang yang tak berdasar");
                            Console.ReadLine();
                            Console.WriteLine("ANDA KALAH!\n");
                            finalQuestion2 = true;
                        }
                    } 
                        if(skor >= 80){
                            Console.WriteLine("Nilai bahasa inggris anda sangat tinggi, saya harap anda dapat meningkatkan kemampuan berbahasa anda");
                        } else {
                            Console.WriteLine("Anda bisa meningkatkan lagi kemampuan anda, jangan patah semangat");
                        }
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
} else if (opsi == 2){
    Console.WriteLine("Mengakhiri permainan...");
}