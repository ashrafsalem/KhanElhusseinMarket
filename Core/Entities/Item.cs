namespace Core.Entities
{
    public class Item
    {
        public int ID {get; set;}
        //to fix search with barcoe starts with 0
        public string ItemBarcode {get; set;}
        public string ItemName{get; set;}
        public int ItemCategoryID {get; set;}
        public float Qty {get; set;}

        public float CostPrice {get; set;}
        public float SalePrice {get; set;}

        public float RorderPoint {get; set;}
        public bool IsActive {get; set;}
    }
}