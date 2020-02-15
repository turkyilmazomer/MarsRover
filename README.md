# MarsRover
Bir robot gezgin takımı NASA tarafından Mars'taki bir platoya inecek. İlginç bir şekilde dikdörtgen olan bu plato, gemideki kameralarının Dünya'ya geri göndermek için çevredeki araziyi tam olarak görebilmeleri için geziciler tarafından yönlendirilecek.

Bir gezicinin pozisyionu ve konumu, X ve Y koordinatlarının bir kombinasyonu ve dört kardinal pusula noktasından birini temsil eden bir harfle temsil edilir. Plato, navigasyonu kolaylaştırmak için bir ızgaraya bölünmüştür.

Örnek bir konum 0, 0, N olabilir; bu, gezginin sol alt köşede ve kuzeye baktığı anlamına gelir.

Bir gezici kontrol etmek için, NASA harflerin basit bir dize gönderir. Olası harfler 'L', 'R' ve 'M'dir. 

'L 've' R', rover spin'i şu anki noktasından hareket etmeden sırasıyla 90 derece sola veya sağa çevirir.

'M', bir ızgara noktasını ileriye taşımak ve aynı istikameti korumak anlamına gelir.

(X, Y) 'den doğrudan Kuzey karesinin (x, y + 1) olduğunu varsayalım.

----------------------------------------------------------------------------------------------------------------------------------------

İlk girdi satırı platonun sağ üst koordinatlarıdır, sol alt koordinatların 0,0 olduğu varsayılır.
Girişin geri kalanı, dağıtılan gezicilere ait bilgidir.
Her gezici iki giriş satırına sahiptir. İlk satır, gezicinin pozisyonunu verir ve ikinci satır, geziciye platoyu nasıl keşfedeceğini anlatan bir dizi talimattır.
Pozisyon, X ve Y koordinatlarına ve gezici yönüne karşılık gelen boşluklarla ayrılmış iki tamsayıdan ve bir harften oluşur.(Örnek 1 1 N)
Her gezici sırayla tamamlanacaktır, bu da ikinci gezicinin ilk gezici tamamlanana kadar hareket etmeye başlamayacağı anlamına gelir.

----------------------------------------------------------------------------------------------------------------------------------------

Her gezici için çıktı, nihai koordinatları ve istikameti olmalıdır.

Input and Output
Test Input: 
5 5 
1 2 N 
LMLMLMLMM 
3 3 E 
MMRMMRMRRM

Expected Output: 
1 3 N 
5 1 E

