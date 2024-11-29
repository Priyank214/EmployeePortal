document.getElementById('contactForm').addEventListener('submit', function (event) {
    event.preventDefault(); // Prevent the form from submitting normally

    let isValid = true;

    // Get form fields
    const firstName = document.getElementById('firstName');
    const lastName = document.getElementById('lastName');
    const email = document.getElementById('email');
    const contactNumber = document.getElementById('contactNumber');
    const message = document.getElementById('message');

    // Clear previous error messages
    const errorMessages = document.querySelectorAll('.error-message');
    errorMessages.forEach(function (error) {
        error.style.display = 'none';
    });

    // Check if fields are not empty
    if (firstName.value.trim() === '') {
        isValid = false;
        displayError('firstNameError', 'First name is required');
    }
    if (lastName.value.trim() === '') {
        isValid = false;
        displayError('lastNameError', 'Last name is required');
    }
    if (email.value.trim() === '') {
        isValid = false;
        displayError('emailError', 'Email address is required');
    }
    if (contactNumber.value.trim() === '') {
        isValid = false;
        displayError('contactNumberError', 'Contact number is required');
    }
    if (message.value.trim() === '') {
        isValid = false;
        displayError('messageError', 'Message is required');
    }

    // Check email format
    if (email.value.trim() !== '' && !validateEmail(email.value)) {
        isValid = false;
        displayError('emailError', 'Please enter a valid email address');
    }

    // Check phone number format
    if (contactNumber.value.trim() !== '' && !validatePhoneNumber(contactNumber.value)) {
        isValid = false;
        displayError('contactNumberError', 'Please enter a valid contact number');
    }

    // If form is valid, simulate form submission
    if (isValid) {
        // Simulate form submission by redirecting (this could be an AJAX call or redirect to a Thank You page)
        event.target.submit();
        document.getElementById('contactForm').reset(); // Reset form after successful submission
    }
});

function displayError(errorId, message) {
    const errorElement = document.getElementById(errorId);
    errorElement.style.display = 'block';
    errorElement.innerText = message;
}

function validateEmail(email) {
    const re = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;
    return re.test(String(email).toLowerCase());
}

function validatePhoneNumber(phone) {
    const re = /^[0-9]{10}$/;
    return re.test(String(phone));
}
