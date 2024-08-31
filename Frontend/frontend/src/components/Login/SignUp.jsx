import React, { useState } from 'react';
import axios from 'axios';
import LogoLogin from "../assets/logoLogin.png";
import { Eye, EyeSlash } from "@phosphor-icons/react";

const SignUp = ({ onSignInClick }) => {
    const [name, setName] = useState('');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [error, setError] = useState('');
    const [showPassword, setShowPassword] = useState(false); // Estado para controlar visibilidade da senha

    const handleSubmit = async (event) => {
        event.preventDefault();

        try {
            const response = await axios.post('https://localhost:7266/api/User/Create', {
                imageUser: 'guigas',
                nameUser: name,
                emailUser: email,
                passwordUser: password,
                phoneUser: '(17)99999-9999',
            });

            if (response.status === 200) {
                alert('Usuário cadastrado com sucesso!');
            }
        } catch (error) {
            setEmail('Falha ao cadastrar o usuário. Verifique os dados e tente novamente.');
        }
    };
}