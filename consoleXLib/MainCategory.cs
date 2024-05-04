using System;


namespace consoleXLib
{
    public class MainCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public MainCategory(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public void AddMainCategory()
        {
            // Implementation for adding a main category
        }

        public void EditMainCategory()
        {
            // Implementation for editing a main category
        }

        public void DeleteMainCategory()
        {
            // Implementation for deleting a main category
        }

        public void ViewMainCategory()
        {
            // Implementation for viewing a main category
        }

        public static void AddMainCategory(MainCategory mainCategory)
        {
            // Implementation for adding a main category
        }

        public static void EditMainCategory(int index, MainCategory updatedMainCategory)
        {
            // Implementation for editing a main category
        }

        public static void DeleteMainCategory(int index)
        {
            // Implementation for deleting a main category
        }

        public static MainCategory ViewMainCategory(int index)
        {
            // Implementation for viewing a main category
            return null;
        }
    }
}
