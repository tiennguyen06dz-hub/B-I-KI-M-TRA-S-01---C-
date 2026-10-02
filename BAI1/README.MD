### Câu 1: Phân biệt Value Types và Reference Types
- Value Types:
Lưu trực tiếp giá trị của biến.
Thường lưu trên Stack.
Khi gán biến này cho biến khác thì giá trị được sao chép.
Hai biến hoạt động độc lập.
Ví dụ: int, float, double, bool, struct.
- Reference Types:
Lưu tham chiếu đến đối tượng.
Đối tượng được lưu trên Heap.
Khi gán biến này cho biến khác thì tham chiếu được sao chép.
Hai biến có thể cùng tham chiếu đến một đối tượng.
Ví dụ: class, array, string, object.
-----
### Câu 2: Phân biệt init và set
set:
Cho phép gán giá trị cho thuộc tính.
Có thể thay đổi giá trị sau khi tạo đối tượng.
Ví dụ: sv.Name = "An"; sau đó có thể đổi thành sv.Name = "Bình";.
init:
Chỉ cho phép gán giá trị khi khởi tạo đối tượng.
Không thể thay đổi giá trị sau khi khởi tạo.
Giúp hạn chế việc thay đổi dữ liệu ngoài ý muốn.
Ví dụ: dùng init cho Id, mã sinh viên, mã tài khoản.
-----
### Câu 3: Phân biệt virtual và override
- Virtual:
Được khai báo ở lớp cha.
Cho phép lớp con ghi đè phương thức.
Là cơ sở để thực hiện tính đa hình.
Ví dụ: lớp Animal có phương thức Sound() là virtual.
- override:
Được khai báo ở lớp con.
Dùng để ghi đè phương thức virtual của lớp cha.
Cho phép lớp con có cách thực hiện riêng.
- Ví dụ: lớp Dog ghi đè Sound() để in "Gau gau".
Khi sử dụng:
Animal a = new Dog();
a.Sound();
Kết quả gọi phương thức của Dog.
Đây là tính đa hình.
-----
### Câu 4: Tại sao static không truy xuất thông qua Object?
static thuộc về Class, không thuộc về Object.
Chỉ có một bản static dùng chung cho toàn bộ Class.
Không cần tạo Object bằng new để sử dụng thành phần static.
Truy xuất static thông qua tên Class.
Ví dụ: Student.Count.
Thành phần không static thuộc về từng Object.
Vì vậy, static và Object có phạm vi sử dụng khác nhau.