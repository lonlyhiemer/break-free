body {
    font-family: 'Arial', sans-serif;
    margin: 0;
    padding: 0;
}

header {
    background-color: #3498db;
    color: #fff;
    text-align: center;
    padding: 20px;
}

section {
    padding: 40px;
}

button {
    background-color: #3498db;
    color: #fff;
    padding: 10px 20px;
    border: none;
    cursor: pointer;
}

footer {
    background-color: #2c3e50;
    color: #fff;
    text-align: center;
    padding: 10px;
    position: fixed;
    width: 100%;
    bottom: 0;
}
/* ... (previous code) ... */

#success-stories {
    background-color: #ecf0f1;
    padding: 40px;
}

.success-story {
    margin-bottom: 20px;
    display: flex;
    align-items: center;
}

.success-story img {
    border-radius: 50%;
    margin-right: 15px;
}

#expert-tips {
    background-color: #f39c12;
    color: #fff;
    padding: 40px;
}

#data-visualization {
    background-color: #d35400;
    color: #fff;
    padding: 40px;
}

/* ... (previous code) ... */
/* ... (previous code) ... */

.popup {
    display: none;
    position: fixed;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    background-color: rgba(0, 0, 0, 0.5);
    width: 100%;
    height: 100%;
    justify-content: center;
    align-items: center;
}

.popup-content {
    background-color: #fff;
    padding: 20px;
    border-radius: 8px;
    text-align: center;
}

.close-btn {
    position: absolute;
    top: 10px;
    right: 10px;
    cursor: pointer;
}

/* ... (previous code) ... */
/* ... (previous code) ... */

.popup {
    display: none;
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.7);
    justify-content: center;
    align-items: center;
    z-index: 1000;
    opacity: 0;
    animation: fadeIn 0.5s forwards;
}

.popup-content {
    background-color: #fff;
    padding: 20px;
    border-radius: 8px;
    text-align: center;
    animation: slideIn 0.5s forwards;
}

.close-btn {
    position: absolute;
    top: 10px;
    right: 10px;
    cursor: pointer;
    color: #333;
    font-size: 20px;
    transition: color 0.3s;
}

.close-btn:hover {
    color: #e74c3c;
}

@keyframes fadeIn {
    from {
        opacity: 0;
    }

    to {
        opacity: 1;
    }
}

@keyframes slideIn {
    from {
        transform: translateY(-50px);
        opacity: 0;
    }

    to {
        transform: translateY(0);
        opacity: 1;
    }
}

/* ... (previous code) ... */
/* ... (previous code) ... */

#cta {
    background-color: #27ae60;
    color: #fff;
    text-align: center;
    padding: 40px;
}

#cta button {
    background-color: #2ecc71;
    color: #fff;
    padding: 10px 20px;
    border: none;
    cursor: pointer;
}

#testimonials {
    background-color: #ecf0f1;
    text-align: center;
    padding: 40px;
}

.testimonial-carousel {
    display: flex;
    justify-content: space-around;
    margin-top: 20px;
    overflow: hidden;
}

.testimonial {
    background-color: #fff;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    width: 300px;
}

.testimonial span {
    display: block;
    margin-top: 10px;
    font-weight: bold;
}

/* ... (previous code) ... */
/* ... (previous code) ... */

#featured-content {
    background-color: #3498db;
    color: #fff;
    text-align: center;
    padding: 40px;
}

.featured-item {
    margin-top: 20px;
}

.featured-item img {
    max-width: 100%;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(255, 255, 255, 0.5);
}

/* ... (previous code) ... */
/* ... (previous code) ... */

header {
    background-color: #3498db;
    color: #fff;
    text-align: center;
    padding: 20px;
    position: fixed;
    width: 100%;
    z-index: 1000;
    transition: background-color 0.3s ease;
}

header.navbar-scroll {
    background-color: #2980b9;
}

nav ul {
    list-style: none;
    margin: 0;
    padding: 0;
}

nav li {
    display: inline-block;
    margin-right: 20px;
}

nav a {
    text-decoration: none;
    color: #fff;
    font-weight: bold;
    font-size: 16px;
    transition: color 0.3s ease;
}

nav a:hover {
    color: #ecf0f1;
}

/* ... (previous code) ... */
/* ... (previous code) ... */

#get-started button {
    background-color: #3498db;
    color: #fff;
    padding: 15px 30px;
    border: none;
    cursor: pointer;
    font-size: 18px;
    border-radius: 8px;
    transition: transform 0.3s ease;
}

#get-started button:hover {
    transform: scale(1.05);
}

/* ... (previous code) ... */
/* ... (previous code) ... */

#meet-the-team {
    background-color: #ecf0f1;
    text-align: center;
    padding: 40px;
}

.team-member {
    margin-top: 20px;
    border-radius: 8px;
    overflow: hidden;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

.team-member img {
    max-width: 100%;
    border-bottom: 1px solid #3498db;
}

.team-member h3 {
    margin: 10px 0;
    color: #3498db;
}

/* ... (previous code) ... */
/* ... (previous code) ... */

#tips-and-tricks {
    background-color: #ecf0f1;
    text-align: center;
    padding: 40px;
}

.tip-card {
    margin-top: 20px;
    border-radius: 8px;
    overflow: hidden;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    cursor: pointer;
    transition: transform 0.3s ease;
}

.tip-card img {
    max-width: 100%;
    border-bottom: 1px solid #3498db;
}

.tip-card h3 {
    margin: 10px 0;
    color: #3498db;
}

.tip-card:hover {
    transform: scale(1.05);
}

/* ... (previous code) ... */
/* ... (previous code) ... */

#tips-and-tricks {
    background-color: #ecf0f1;
    text-align: center;
    padding: 40px;
}

.tip-card {
    margin-top: 20px;
    border-radius: 8px;
    overflow: hidden;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    cursor: pointer;
    transition: transform 0.3s ease;
}

.tip-card img {
    max-width: 100%;
    border-bottom: 1px solid #3498db;
}

.tip-card h3 {
    margin: 10px 0;
    color: #3498db;
}

.tip-card:hover {
    transform: scale(1.05);
}

/* ... (previous code) ... */
