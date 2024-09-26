$("#catalog-filter").on("input", function () {
  var inputText = $(this).val().toLowerCase(); // Get the input text and convert to lowercase for case-insensitive search

  $(".catalog-category").each(function () {
    var categoryVisible = false; // Flag to determine if any part of the category should be visible

    // Check if the category name contains the input text
    var categoryName = $(this).find("strong a").text().toLowerCase();
    if (categoryName.includes(inputText)) {
      categoryVisible = true;
    }

    // Check subcategories
    $(this)
      .find(".catalog-subcategory")
      .each(function () {
        var subCategoryName = $(this).text().toLowerCase();

        // Show or hide subcategory based on input text
        if (subCategoryName.includes(inputText)) {
          $(this).parent().show(); // Show the <li> containing the subcategory
          categoryVisible = true; // If a subcategory matches, show the parent category
        } else {
          $(this).parent().hide(); // Hide the subcategory <li> if it doesn't match
        }
      });

    // Show or hide the category based on whether any subcategory or the category name matches
    if (categoryVisible) {
      $(this).show();
    } else {
      $(this).hide();
    }
  });
});
