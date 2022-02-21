# clone-website-dantri
clone page  https://dantri.com.vn/

# cách push file lên github

# b1: kiểm tra trạng thái của file
    git status
- những file màu đỏ là những file mới

# b2: thêm những file muốn đẩy lên github
    git add 

# b3: kiểm tra lại file, nếu màu xanh thì có để push lên github được

    git status

# b4: đẩy lên github

    git pust origin main

# icon https://fontawesome.com/



# Nhận xét

# 2022/02/21

- width sub-menu để co dãn tự động
 + hãy sửa width thành min-width (nếu dùng width thì luôn động rộng luôn luôn như vậy, để thành min-width thì nội dung nhiều tự động chiều rộng của sub-menu sẽ đc dài ra tự động)
 + tìm hiểu thuộc tính  transition (đây là hiệu ứng)
 + tìm hiểu hiệu ứng transform (vd transform: translateY(15px);)

- chỉnh lại màu class clear -> đổi thành class như này divider

- mỗi 1 khối hãy dùng comment để comment code nhìn cho dễ đọc, ví dụ
+ comment bên css 
    /* menu */
    do something
    /* slide */
    do something

+ comment bên html
    <!-- start menu-->   
    code html
    <!-- end menu-->  

- hạn chế css cho id, nên đặt css để css (id sẽ dùng cho việc khác nên hạn chế dùng id)

- chữ Blog(bên tay phải, cột thứ 3) khi hover vào không hiển thị chữ màu xanh(màu chữ đang sai hãy sửa lại)

