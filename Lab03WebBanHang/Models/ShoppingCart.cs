namespace Lab03WebBanHang.Models
{
    public class ShoppingCart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public void AddItem(CartItem item)
        {
            var existingItem = Items.FirstOrDefault(i => i.ProductId == item.ProductId);

            if (existingItem != null)
            {
                // Nếu sản phẩm đã có trong giỏ → tăng số lượng
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                // Nếu chưa có → thêm mới vào giỏ
                Items.Add(item);
            }
        }

        public void RemoveItem(int productId)
        {
            // Xóa tất cả các CartItem có ProductId trùng với productId
            Items.RemoveAll(i => i.ProductId == productId);
        }

    }
}
