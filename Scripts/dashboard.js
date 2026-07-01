document.addEventListener("DOMContentLoaded", function () {

    // Animated Counter
    document.querySelectorAll(".stat-card h2").forEach(counter => {

        let text = counter.innerText.replace(/[₹,]/g, "");
        let target = parseInt(text);

        if (isNaN(target)) return;

        let current = 0;
        let step = Math.max(1, Math.ceil(target / 60));

        function update() {

            current += step;

            if (current >= target) {

                current = target;

            }

            counter.innerHTML = (counter.innerHTML.includes("₹") ? "₹" : "") +
                current.toLocaleString();

            if (current < target) {

                requestAnimationFrame(update);

            }

        }

        update();

    });

    // Greeting

    const hour = new Date().getHours();

    const title = document.querySelector(".hero-section h1");

    if (!title) return;

    if (hour < 12)

        title.innerHTML = 'Good Morning, <span>Admin</span> 👋';

    else if (hour < 17)

        title.innerHTML = 'Good Afternoon, <span>Admin</span> 👋';

    else

        title.innerHTML = 'Good Evening, <span>Admin</span> 👋';

});