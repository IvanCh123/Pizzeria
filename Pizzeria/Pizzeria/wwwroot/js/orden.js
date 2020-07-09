$("#prevBtn").click(function () {
    $("#nextBtn").removeAttr('disabled')
})

var totalTamaño = 0;
var totalCobertura = 0;

$('input[type=radio]').change(function () {
    var tipo = $('input[name=tamaño]:checked', '#regForm').val()

    var precio = $('label[id=precio-' + tipo + ']', '#regForm').html()

    totalTamaño = parseInt(precio.slice(4, precio.length - 3));

    $("#total").html(totalTamaño + totalCobertura);
    $("#total2").val(totalTamaño + totalCobertura);

    $("#nextBtn").removeAttr('disabled')
});

$('input[type=checkbox]').change(function () {

    var temp = 0;
    if ($('#regForm input[type="checkbox"]').is(':checked')) {

        $.each($("input[name='cobertura']:checked"), function () {

            var tipo = $(this).val()

            var precio = $('label[id=precio-' + tipo + ']', '#regForm').html()

            temp += parseInt(precio.slice(4, precio.length - 3))
        });


        $("#nextBtn").removeAttr('disabled')
    } else{
        $("#nextBtn").attr('disabled', 'disabled')
    }

    totalCobertura = temp;

    $("#total").html( (totalTamaño + totalCobertura))
    $("#total2").val( (totalTamaño + totalCobertura))
});


var currentTab = 0; // Current tab is set to be the first tab (0)
showTab(currentTab); // Display the current tab

function showTab(n) {
  // This function will display the specified tab of the form...
  var x = document.getElementsByClassName("tab");
  x[n].style.display = "block";
  //... and fix the Previous/Next buttons:
  if (n == 0) {
    document.getElementById("prevBtn").style.display = "none";
  } else {
    document.getElementById("prevBtn").style.display = "inline";
  }
  if (n == (x.length - 1)) {
      document.getElementById("nextBtn").innerHTML = "Ver recibo";
      $("#nextBtn").removeAttr('type')
      $("#nextBtn").attr('type','submit')
  } else {
      document.getElementById("nextBtn").innerHTML = "Siguiente";
      $("#nextBtn").removeAttr('type')
      $("#nextBtn").attr('type', 'button')
  }
  //... and run a function that will display the correct step indicator:
  fixStepIndicator(n)
}

function nextPrev(n) {
  // This function will figure out which tab to display
  var x = document.getElementsByClassName("tab");
  // Hide the current tab:
  x[currentTab].style.display = "none";
  // Increase or decrease the current tab by 1:
  currentTab = currentTab + n;
  // if you have reached the end of the form...
  if (currentTab >= x.length) {
    // ... the form gets submitted:
    document.getElementById("regForm").submit();
    return false;
  }
  // Otherwise, display the correct tab:
  showTab(currentTab);

    $("#nextBtn").attr('disabled','disabled')
}

function fixStepIndicator(n) {
  // This function removes the "active" class of all steps...
  var i, x = document.getElementsByClassName("step");
  for (i = 0; i < x.length; i++) {
    x[i].className = x[i].className.replace(" active", "");
  }
  //... and adds the "active" class on the current step:
  x[n].className += " active";
}