import React from "react"
import Logo from '../../assets/logoLogin.png'

const Navbar = () => {
    <div className='flex w-full bg-[#BD1A37] sm:h-[64px] h-[56px] px-4 items-center drop-shadow-md'>
        <Logo />
        <div className='flex w-full justify-end'>
            <div className='bg-blue-400 rounded-full w-8 h-8'>
                {/* Avatar */}
            </div>
        </div>
    </div>
}

export default Navbar