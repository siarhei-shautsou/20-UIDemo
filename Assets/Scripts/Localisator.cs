using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Localisator : MonoBehaviour
{
    #region Text Objects Declaration
    [SerializeField] TextMeshProUGUI mainLabel;
    [SerializeField] TextMeshProUGUI sButton;
    [SerializeField] TextMeshProUGUI startButton;
    [SerializeField] TextMeshProUGUI oButton;
    [SerializeField] TextMeshProUGUI optionsButton;
    [SerializeField] TextMeshProUGUI qButton;
    [SerializeField] TextMeshProUGUI quitButton;
    [SerializeField] TextMeshProUGUI optionsLabel;
    [SerializeField] TextMeshProUGUI screenLabel;
    [SerializeField] TextMeshProUGUI soundLabel;
    [SerializeField] TextMeshProUGUI fontSizeLabel;
    [SerializeField] TextMeshProUGUI fontColorLabel;
    [SerializeField] TextMeshProUGUI uiPaletteLabel;
    [SerializeField] TextMeshProUGUI darkButton;
    [SerializeField] TextMeshProUGUI lightButton;
    [SerializeField] TextMeshProUGUI languageLabel;
    [SerializeField] TMP_Dropdown languageDropdown;
    [SerializeField] TextMeshProUGUI languageDropdownLabel;
    [SerializeField] TextMeshProUGUI effectsLabel;
    [SerializeField] TextMeshProUGUI musicLabel;
    [SerializeField] TextMeshProUGUI themeLabel;
    [SerializeField] TMP_Dropdown themeDropdown;
    [SerializeField] TextMeshProUGUI themeDropdownLabel;
    [SerializeField] TextMeshProUGUI backButton;
    #endregion

    Dictionary<string, string> english = new Dictionary<string, string>();
    Dictionary<string, string> russian = new Dictionary<string, string>();
    public static bool isEnglish = true;

    // Start is called before the first frame update
    void Start()
    {
        InitializeEngDictionary();
        InitializeRusDictionary();
    }

    public void SetLanguage(int index)
    {
        if (index == 0)
        {
            if (!isEnglish)
            {
                SetEnglish();
            }
        }
        else
        {
            if (isEnglish)
            {
                SetRussian();
            }
        }
    }

    void SetRussian()
    {
        mainLabel.text = russian["mainLabel"];
        sButton.text = russian["sButton"];
        startButton.text = russian["startButton"];
        oButton.text = russian["oButton"];
        optionsButton.text = russian["optionsButton"];
        qButton.text = russian["qButton"];
        quitButton.text = russian["quitButton"];
        optionsLabel.text = russian["optionsLabel"];
        screenLabel.text = russian["screenLabel"];
        soundLabel.text = russian["soundLabel"];
        fontSizeLabel.text = russian["fontSizeLabel"];
        fontColorLabel.text = russian["fontColorLabel"];
        uiPaletteLabel.text = russian["uiPaletteLabel"];
        darkButton.text = russian["darkButton"];
        lightButton.text = russian["lightButton"];
        languageLabel.text = russian["languageLabel"];

        if (languageDropdown.value == 0)
        {
            languageDropdownLabel.text = russian["englishDropdown"];
        }
        else
        {
            languageDropdownLabel.text = russian["russianDropdown"];
        }

        languageDropdown.options[0].text = russian["englishDropdown"];
        languageDropdown.options[1].text = russian["russianDropdown"];
        effectsLabel.text = russian["effectsLabel"];
        musicLabel.text = russian["musicLabel"];
        themeLabel.text = russian["themeLabel"];

        if (themeDropdown.value == 0)
        {
            themeDropdownLabel.text = russian["funnyDropdown"];
        }
        else if (themeDropdown.value == 1)
        {
            themeDropdownLabel.text = russian["neutralDropdown"];
        }
        else
        {
            themeDropdownLabel.text = russian["spookyDropdown"];
        }

        themeDropdown.options[0].text = russian["funnyDropdown"];
        themeDropdown.options[1].text = russian["neutralDropdown"];
        themeDropdown.options[2].text = russian["spookyDropdown"];
        backButton.text = russian["backButton"];

        SetSpacing(5);
        isEnglish = false;

        ParamsKeeper.Text = russian["mainLabel"];
        ParamsKeeper.isTextChanged = true;
    }

    void SetEnglish()
    {
        mainLabel.text = english["mainLabel"];
        sButton.text = english["sButton"];
        startButton.text = english["startButton"];
        oButton.text = english["oButton"];
        optionsButton.text = english["optionsButton"];
        qButton.text = english["qButton"];
        quitButton.text = english["quitButton"];
        optionsLabel.text = english["optionsLabel"];
        screenLabel.text = english["screenLabel"];
        soundLabel.text = english["soundLabel"];
        fontSizeLabel.text = english["fontSizeLabel"];
        fontColorLabel.text = english["fontColorLabel"];
        uiPaletteLabel.text = english["uiPaletteLabel"];
        darkButton.text = english["darkButton"];
        lightButton.text = english["lightButton"];
        languageLabel.text = english["languageLabel"];

        if (languageDropdown.value == 0)
        {
            languageDropdownLabel.text = english["englishDropdown"];
        }
        else
        {
            languageDropdownLabel.text = english["russianDropdown"];
        }

        languageDropdown.options[0].text = english["englishDropdown"];
        languageDropdown.options[1].text = english["russianDropdown"];
        effectsLabel.text = english["effectsLabel"];
        musicLabel.text = english["musicLabel"];
        themeLabel.text = english["themeLabel"];

        if (themeDropdown.value == 0)
        {
            themeDropdownLabel.text = english["funnyDropdown"];
        }
        else if (themeDropdown.value == 1)
        {
            themeDropdownLabel.text = english["neutralDropdown"];
        }
        else
        {
            themeDropdownLabel.text = english["spookyDropdown"];
        }

        themeDropdown.options[0].text = english["funnyDropdown"];
        themeDropdown.options[1].text = english["neutralDropdown"];
        themeDropdown.options[2].text = english["spookyDropdown"];
        backButton.text = english["backButton"];

        SetSpacing(20);
        isEnglish = true;

        ParamsKeeper.isTextChanged = true;
        ParamsKeeper.Text = english["mainLabel"];
    }

    void InitializeEngDictionary()
    {
        english.Add("mainLabel", "UI Demo");
        english.Add("sButton", "S");
        english.Add("startButton", "Start");
        english.Add("oButton", "O");
        english.Add("optionsButton", "Options");
        english.Add("qButton", "Q");
        english.Add("quitButton", "Quit");
        english.Add("optionsLabel", "Options");
        english.Add("screenLabel", "Screen");
        english.Add("soundLabel", "Sound");
        english.Add("fontSizeLabel", "Font size");
        english.Add("fontColorLabel", "Font color");
        english.Add("uiPaletteLabel", "Palette");
        english.Add("darkButton", "Dark");
        english.Add("lightButton", "Light");
        english.Add("languageLabel", "Language");
        english.Add("languageDropdownLabel", "English");
        english.Add("englishDropdown", "English");
        english.Add("russianDropdown", "Russian");
        english.Add("effectsLabel", "Effects");
        english.Add("musicLabel", "Music");
        english.Add("themeLabel", "Theme");
        english.Add("funnyDropdown", "Funny");
        english.Add("neutralDropdown", "Neutral");
        english.Add("spookyDropdown", "Spooky");
        english.Add("backButton", "Back");
    }
    void InitializeRusDictionary()
    {
        russian.Add("mainLabel", "Демонстрация UI");
        russian.Add("sButton", "С");
        russian.Add("startButton", "Старт");
        russian.Add("oButton", "О");
        russian.Add("optionsButton", "Опции");
        russian.Add("qButton", "В");
        russian.Add("quitButton", "Выйти");
        russian.Add("optionsLabel", "Настройки");
        russian.Add("screenLabel", "Экран");
        russian.Add("soundLabel", "Звук");
        russian.Add("fontSizeLabel", "Размер текста");
        russian.Add("fontColorLabel", "Цвет текста");
        russian.Add("uiPaletteLabel", "Палитра");
        russian.Add("darkButton", "Тёмн.");
        russian.Add("lightButton", "Свет.");
        russian.Add("languageLabel", "Язык");
        russian.Add("languageDropdownLabel", "Английский");
        russian.Add("englishDropdown", "Английский");
        russian.Add("russianDropdown", "Русский");
        russian.Add("effectsLabel", "Эффекты");
        russian.Add("musicLabel", "Музыка");
        russian.Add("themeLabel", "Тема");
        russian.Add("funnyDropdown", "Весёлая");
        russian.Add("neutralDropdown", "Нейтр.");
        russian.Add("spookyDropdown", "Мрачная");
        russian.Add("backButton", "Назад");
    }

    void SetSpacing(float spacing)
    {
        mainLabel.characterSpacing = spacing;
        sButton.characterSpacing = spacing;
        startButton.characterSpacing = spacing;
        oButton.characterSpacing = spacing;
        optionsButton.characterSpacing = spacing;
        qButton.characterSpacing = spacing;
        quitButton.characterSpacing = spacing;
        optionsLabel.characterSpacing = spacing;
        screenLabel.characterSpacing = spacing;
        soundLabel.characterSpacing = spacing;
        fontSizeLabel.characterSpacing = spacing;
        fontColorLabel.characterSpacing = spacing;
        uiPaletteLabel.characterSpacing = spacing;
        darkButton.characterSpacing = spacing;
        lightButton.characterSpacing = spacing;
        languageLabel.characterSpacing = spacing;
        effectsLabel.characterSpacing = spacing;
        musicLabel.characterSpacing = spacing;
        themeLabel.characterSpacing = spacing;
        backButton.characterSpacing = spacing;
        languageDropdownLabel.characterSpacing = spacing;
        themeDropdownLabel.characterSpacing = spacing;
    }
}
