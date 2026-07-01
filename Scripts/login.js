document.addEventListener("DOMContentLoaded", function () {

    const password = document.getElementById("password");

    const eye = document.getElementById("togglePassword");

    if (password && eye) {

        eye.onclick = function () {

            if (password.type === "password") {

                password.type = "text";

                eye.classList.remove("ri-eye-line");

                eye.classList.add("ri-eye-off-line");

            }

            else {

                password.type = "password";

                eye.classList.remove("ri-eye-off-line");

                eye.classList.add("ri-eye-line");

            }

        }

    }

    const btn = document.getElementById("loginBtn");

    if (btn) {

        btn.addEventListener("click", function () {

            btn.innerHTML = "Signing In...";

        });

    }

});