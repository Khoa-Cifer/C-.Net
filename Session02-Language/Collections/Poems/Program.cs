namespace Poems
{
    //namespace Poemsv~ package poems; ben java
    //Mang y nghia: tap tin nay, class nam trong tap tin nay co dia chi, noi sinh, nam o thu muc Poems

    //Tai sao lai can khai niem namespace hay package ?
    //De chia tap tin source code, cac class ve cac thu muc cho de phan loai, dao, dto, service, controller
    //De cho phep cac class cung project trung ten nhau, tap tin trung ten nhau, mien khac thu muc.
    internal class Program
    {
        //Trong 1 class co gi
        //member of a class including:
            //Fields - attributes/properties and methods
        //Nom na:          bien (toan cuc)        ham
        //Static fields         and non-static fields
        //class level variable      instance variable
        static void Main(string[] args)
        {
            PrintSongXuanQuynhV6();
            //PrintPath();
            Console.ReadLine();
        }

        static void PrintSongXuanQuynhV6()
        {
            //In tua de bai tho kem nam xb 1967 kem so nam ra doi
            //Console.WriteLine("Song - Xuan Quynh");
            int year = 1967;
            //Console.WriteLine("Song - Xuan Quynh - " + year + " - " + (2024 - year) + " Nam");
            //Goi la concatenation

            Console.WriteLine($@"\nSong - Xuan Quynh - {year} - {(2024 - year)} Nam");
            //Ki thuat noi suy chuoi, rang tim trong chuoi cho nao la bien, thi thay value vao
            //Interpolation: Chuoi viet kem bien qua ki tu $, noi suy ra bien
            //Hay dung nhat, vi gan nhat voi wysiwyg
            Console.WriteLine("Song - Xuan Quynh - {0} - {1} Nam", year, (2024 - year));
            //Ki thuat tao chuoi theo style place holder, dien vao cho trong, chuoi can in cu lam theo style wysiwyg
            //chua cho co cac bien can dien = dau {}
            //cac bien den ty 0, 1, 2

            string msg = $@"\nSong - Xuan Quynh - {year} - {(2024 - year)} Nam";
            Console.WriteLine(msg);
        }

        //Dau @ dung truoc 1 chuoi bat ki se bien chuoi nhanh thanh chuoi nguyen ban, raw string -> co sai in vay.
        //Luc go code, in ra y chang, phe luon cac ki tu dac biet con lai
        //\n in ra \n luon
        //Chuoi nguyen ban 0 STYKE WYSTIWYG
        //hay con goi la VERGATIM STRING, dc dung khi in ra 1 thu gi do, ma ngay luc go ta muon thay no y change, the dam bao het qua nhu mong muon
        //Khi ta dung de luu tru ten cua duong dan tro den tap tin va thu muc va ten server trong cau lenh ket noi co so du lieu - ta muon nhin chuoi dc tu nhien
        static void PrintSongXuanQuynhV5()
        {
            Console.WriteLine(@"SONG' 1967
            Dữ dội và dịu êm
            Ồn ào và lặng lẽ
            Sông không hiểu nổi mình
            Sóng tìm ra tận bể

            Ôi con sóng ngày xưa
            Và ngày sau vẫn thế
            Nỗi khát vọng tình yêu
            Bồi hồi trong ngực trẻ

            Trước muôn trùng sóng bể
            Em nghĩ về anh, em
            Em nghĩ về biển lớn
            Từ nơi nào sóng lên?

            Sóng bắt đầu từ gió
            Gió bắt đầu từ đâu?
            Em cũng không biết nữa
            Khi nào ta yêu nhau");
        }

        static void PrintSongXuanQuynhV4()
        {
            Console.WriteLine("Dữ dội và dịu êm\r\nỒn ào và lặng lẽ\r\nSông không hiểu nổi mình\r\nSóng tìm ra tận bể\r\n\r\nÔi con sóng ngày xưa\r\nVà ngày sau vẫn thế\r\nNỗi khát vọng tình yêu\r\nBồi hồi trong ngực trẻ\r\n\r\nTrước muôn trùng sóng bể\r\nEm nghĩ về anh, em\r\nEm nghĩ về biển lớn\r\nTừ nơi nào sóng lên?\r\n\r\nSóng bắt đầu từ gió\r\nGió bắt đầu từ đâu?\r\nEm cũng không biết nữa\r\nKhi nào ta yêu nhau");
        }

        static void PrintSongXuanQuynhV3()
        {
            Console.WriteLine(
                "Song bat dau tu gio\n" +
                "Gio bat dau tu dau\n" +
                "Em cung khong biet nua\n" +
                "Khi nao ta yeu nhau"
                );
            //+ duoc goi la toan thu noi chuoi - concatenated
        }

        static void PrintSongXuanQuynhV2()
        {
            Console.WriteLine(
                "Song bat dau tu gio\n" +
                "Gio bat dau tu dau\n" +
                "Em cung khong biet nua\n" + 
                "Khi nao ta yeu nhau"
                );
            //\n la xuong hang
            //in \ ko phai la in \ ma la di ghep voi thang khac ra 1 thang khac nua
            //\ di ghep voi \n, \t, \a
        }

        //Co cau: static chi choi voi static
        //Challenge 1: Viet ham in ra kho tho 4 cau cua bai tho song cua Xuan Quynh
        static void PrintSongXuanQuynh()
        {
            Console.WriteLine("Song bat dau tu gio"); //cw tab = sout tab
            Console.WriteLine("Gio bat dau tu dau");
            Console.WriteLine("Em cung khong biet nua");
            Console.WriteLine("Khi nao ta yeu nhau");
        }

        //Challenge 2: In ra duong dan ten thu muc tap tin
        //C:\Program Files\dotnet
        //C:\news\showbiz\anh-trai-say-hi
        static void PrintPath()
        {
            Console.WriteLine("C:\\Program Files\\dotnet");
            Console.WriteLine("C:\\news\\showbiz\\anh-trai-say-hi");

            Console.WriteLine(@"C:\Program Files\dotnet");
            Console.WriteLine(@"C:\news\showbiz\anh-trai-say-hi");
        }
    }
}
