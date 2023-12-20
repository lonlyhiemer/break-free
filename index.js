// ... (previous code) ...

// Example data for the usage chart
const usageData = {
    labels: ['Week 1', 'Week 2', 'Week 3', 'Week 4'],
    datasets: [{
        label: 'Social Media Usage (hours)',
        data: [20, 15, 10, 5],
        backgroundColor: 'rgba(52, 152, 219, 0.5)',
        borderColor: 'rgba(52, 152, 219, 1)',
        borderWidth: 1
    }]
};

// Render the usage chart
const usageChart = new Chart(document.getElementById('usage-chart').getContext('2d'), {
    type: 'bar',
    data: usageData,
    options: {
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});

// ... (additional code for interactive features) ...
// ... (previous code) ...

// Display the login popup
function showLoginPopup() {
    document.getElementById('login-popup').style.display = 'flex';
}

// Close the login popup
function closeLoginPopup() {
    document.getElementById('login-popup').style.display = 'none';
}

// Submit login form (you can add your own logic here)
function submitLogin() {
    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;

    // Add your authentication logic here (e.g., check against a database)
    // For simplicity, let's just close the popup for now
    closeLoginPopup();
}

// ... (additional code for interactive features) ...
// ... (previous code) ...

let testimonialIndex = 0;

// Auto-scroll testimonials
function autoScrollTestimonials() {
    const testimonials = document.querySelectorAll('.testimonial');
    testimonialIndex = (testimonialIndex + 1) % testimonials.length;

    testimonials.forEach((testimonial, index) => {
        testimonial.style.transform = `translateX(${(index - testimonialIndex) * 100}%)`;
    });
}

// Set interval for auto-scrolling (adjust the duration as needed)
setInterval(autoScrollTestimonials, 5000);

// ... (additional code for interactive features) ...
// ... (previous code) ...

// Add a hover effect for featured items
const featuredItems = document.querySelectorAll('.featured-item');

featuredItems.forEach((item) => {
    item.addEventListener('mouseenter', () => {
        item.style.transform = 'scale(1.05)';
    });

    item.addEventListener('mouseleave', () => {
        item.style.transform = 'scale(1)';
    });
});

// ... (additional code for interactive features) ...
// ... (previous code) ...

// Smooth scrolling for navigation links
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();

        document.querySelector(this.getAttribute('href')).scrollIntoView({
            behavior: 'smooth'
        });
    });
});

// Add animation for the header when scrolling
const header = document.querySelector('header');

window.addEventListener('scroll', () => {
    const scrollPos = window.scrollY;
    if (scrollPos > 20) {
        header.classList.add('navbar-scroll');
    } else {
        header.classList.remove('navbar-scroll');
    }
});

// ... (additional code for interactive features) ...
// ... (previous code) ...

// Add hover effect for team member cards
const teamMembers = document.querySelectorAll('.team-member');

teamMembers.forEach((member) => {
    member.addEventListener('mouseenter', () => {
        member.style.transform = 'scale(1.05)';
    });

    member.addEventListener('mouseleave', () => {
        member.style.transform = 'scale(1)';
    });
});

// ... (additional code for interactive features) ...
// ... (previous code) ...

// Show tip details
function showTipDetails(tipNumber) {
    // Implement logic to display tip details based on tipNumber
    alert(`Tip ${tipNumber}: Implement your logic to show tip details`);
}

// ... (additional code for interactive features) ...
// ... (previous code) ...

// Show tip details
function showTipDetails(tipNumber) {
    // Implement logic to display tip details based on tipNumber
    console.log(`Tip ${tipNumber}: Implement your logic to show tip details`);
}

// ... (additional code for interactive features) ...
